using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using boardchitless.resourceAccess.APIAccessor_twitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;

namespace BoardChitless.Tests.ResourceAccess.APIAccessor_twitter
{
    [TestClass]
    public class twitterAPI_Tests
    {
        private TransactionScope _testTransactionScope;

        #region Properties
        private TwitterApiAccessor Target { get; set; }
        #endregion

        private TestContext _testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }
        


        [TestInitialize]
        public void TestInitialize()
        {
            _testTransactionScope = new TransactionScope();
            
            //Consumer API keys - for @BoardChitless
            //Would I normally hard-code these here?  No. Normally we'd place them in a keyvault on Azure, but seemed like overkill for a code sample.
      
            Target = new TwitterApiAccessor("iNbJLSc1T9fvufuWbFV3V6Xni", "JFjvyyhz56ZvZR1IkGjNSXNBThUT31OUrn43LXMQkCdNyy2CpK", "749359779592613888-wWPrZIls1xVFprjqRunSpKEr5GgaXDp", "rRHz1DhGR9kJ8DwwMjGuMj3uWn9z0t1IIp3YAYDlL4FKm");

        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _testTransactionScope.Dispose();
        }

        [TestMethod]
        public void API_Twitter_Hello()
        {
            Assert.AreNotEqual("Hello", "World");
        }

        [TestMethod]
        public async Task API_Twitter_PostSampleTweet()
        {
            var textMsg = "The date is now " + DateTime.Now.ToString("yyyyMMdd-hhmmss");

            var rtn = await Target.SendTweet(textMsg);
            Assert.IsNotNull(rtn);

            TwitterRtn rtnObj = JsonConvert.DeserializeObject<TwitterRtn>(rtn);
            Assert.IsNotNull(rtnObj.text);
            //Check to make sure the message we posted is the one that is returned.
            Assert.AreEqual(textMsg, rtnObj.text);
            
        }



    }

    public class TwitterRtn
    {
        public long id { get; set; }
        public string id_str { get; set; }
        public string text { get; set; }
        public string truncated { get; set; }


    }
}
