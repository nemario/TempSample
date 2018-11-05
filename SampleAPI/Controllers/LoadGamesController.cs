using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BoardChitless.Manager;

namespace SampleAPI.Controllers
{
    public class LoadGamesController : ApiController
    {
        // GET: api/LoadGames
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/LoadGames/5
        public string Get(int id)
        {

            try
            {
                if (id == 0)
                {
                    return "0f0000";
                }
                else
                {

                    var Mgr = new WebLoad_API_Manager();
                    var rtn = Mgr.pullXMLbyIDSaveToDBAndTweetAboutIt(id.ToString());

                    if (rtn == 100)
                    { return "0s" + id.ToString("xxxx"); }
                    else { return "0f" + id.ToString("xxxx"); }


                }
            }
            catch {
                return "0fzzzz";
            }

                       
        }

        //// POST: api/LoadGames
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/LoadGames/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/LoadGames/5
        //public void Delete(int id)
        //{
        //}
    }
}
