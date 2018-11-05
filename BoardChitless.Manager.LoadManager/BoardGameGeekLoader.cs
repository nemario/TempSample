using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardChitless.ResourceAccess.APIAccessor_boardgamegeek;
using BoardChitless.ResourceAccess.SQLAccessor_BoardChitless;
using BoardChitless.Shared.DataContracts;

namespace BoardChitless.Manager
{
    public class BoardGameGeekLoader
    {

        public string pullXMLbyIDAndSaveToDatabase(string apiKey)
        {

            try {
                var API = new APIAccessor_boardgamegeek_BoardGame();
                var BC = new RawGamesAccessor();

                var xml = API.getBoardGame(apiKey.ToString());
                
                var newGame = new RawGame();

                newGame.APIID = apiKey;
                newGame.TheBlob = xml;

                BC.UpdateOrCreate(newGame);

                return "Done!";
            }
            catch {
                return "Error";
            }


        }


        public string searchAndSaveAllReferences(string searchCriteria)
        {

            try
            {
                var API = new APIAccessor_boardgamegeek_BoardGame();
                var BC = new RawGamesAccessor();

                var xml = API.search(searchCriteria);

                if (xml.Contains("<body>"))
                {
                    return "TimeOut";
                }
                //todo - log the search
                                
                var obj = xml.ParseXML<BoardChitless.Shared.DataContracts.BoardGameGeekSearch.items>();

                foreach (BoardChitless.Shared.DataContracts.BoardGameGeekSearch.itemsItem i in obj.item)
                {

                    var g = new RawGame();

                    g.APIID = i.id.ToString();
                    g.Name = i.name.value.ToString();
                    try
                    {
                        g.YearPublished = i.yearpublished.value;

                        if (i.typeField == "boardgameexpansion")
                        {
                            g.isAlsoExpansion = 1;
                        }

                    }
                    catch {
                    //let it be null
                    }
                    
                    g.RecordType = i.typeField;
                    g.addedBy = "console-search-" + searchCriteria;
                    g.dateAdded = DateTime.UtcNow;
                    
                    //newGame.TheBlob = xml;

                    if (i.name.type == "primary")
                    {
                        BC.UpdateOrCreate(g);
                    }
                    
                }
                
                return "Done";
            }
            catch
            {
                return "Error";
            }
        }
        



    }
}
