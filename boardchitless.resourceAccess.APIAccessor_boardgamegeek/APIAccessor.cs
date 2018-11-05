using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BoardChitless.ResourceAccess.APIAccessor_boardgamegeek
{
   public class APIAccessor_boardgamegeek_BoardGame
    {

        public String getCollection(string userName)
        {

            var client = new RestClient("http://www.boardgamegeek.com/xmlapi2/collection?subtype=boardgame,boardgameexpansion,rpg,rpgitem&username=" + userName);
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "e3758b44-b56a-c720-db23-cd5addbaad74");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Token token=6c1cfe6f99be4e60f9ec4cf5b93a723a");
            IRestResponse response = client.Execute(request);


            String rtn = response.Content;


            return rtn;
            
        }

        public String getHotBoardGames()
        {

            var client = new RestClient("http://www.boardgamegeek.com/xmlapi2/hot?type=boardgame");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "e3758b44-b56a-c720-db23-cd5addbaad74");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Token token=6c1cfe6f99be4e60f9ec4cf5b93a723a");
            IRestResponse response = client.Execute(request);


            String rtn = response.Content;


            return rtn;

        }

        public String getBoardGame(string bggID)
        {

            string URL = "http://www.boardgamegeek.com/xmlapi2/thing?id=" + bggID + "&type=boardgame&stats=1,";

            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
//            request.AddHeader("postman-token", "e3758b44-b56a-c720-db23-cd5addbaad74");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Token token=6c1cfe6f99be4e60f9ec4cf5b93a723a");
            IRestResponse response = client.Execute(request);

            return response.Content;
        }


        public String search(string bggSearchString)
        {

            string URL = "http://www.boardgamegeek.com/xmlapi2/search?type=boardgame,boardgameexpansion,rpg,rpgitem&query=" + bggSearchString;

            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
            //request.AddHeader("postman-token", "e3758b44-b56a-c720-db23-cd5addbaad74");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Token token=6c1cfe6f99be4e60f9ec4cf5b93a723a");
            IRestResponse response = client.Execute(request);
           
            return response.Content;
        }



    }



}
