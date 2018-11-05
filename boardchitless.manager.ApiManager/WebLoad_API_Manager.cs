using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardChitless.Shared.DataContracts;
using BoardChitless.ResourceAccess.APIAccessor_boardgamegeek;
using BoardChitless.ResourceAccess.SQLAccessor_BoardChitless;
using boardchitless.resourceAccess.APIAccessor_twitter;

namespace BoardChitless.Manager
{
    public class WebLoad_API_Manager
    {

        public int pullXMLbyIDSaveToDBAndTweetAboutIt(string apiKey)
        {

            try
            {
                var API = new APIAccessor_boardgamegeek_BoardGame();
                var BC = new RawGamesAccessor();
                var twit = new TwitterApiAccessor("iNbJLSc1T9fvufuWbFV3V6Xni", "JFjvyyhz56ZvZR1IkGjNSXNBThUT31OUrn43LXMQkCdNyy2CpK", "749359779592613888-wWPrZIls1xVFprjqRunSpKEr5GgaXDp", "rRHz1DhGR9kJ8DwwMjGuMj3uWn9z0t1IIp3YAYDlL4FKm");

                var xml = API.getBoardGame(apiKey.ToString());

                var newGame = new RawGame();

                newGame.APIID = apiKey;
                newGame.TheBlob = xml;

                BC.UpdateOrCreate(newGame);

                twit.SendTweet("Someone posted information about Game ID: " + newGame.APIID + " from BGG - " + DateTime.Now.ToString("yyyyMMdd-hhmmss"));

                return 100;
            }
            catch (Exception e)
            {
                return 499;
            }


        }



    }
}
