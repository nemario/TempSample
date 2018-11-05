using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using BoardChitless.ResourceAccess.APIAccessor_boardgamegeek;
using BoardChitless.Shared.DataContracts;
using BoardChitless.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BoardChitless.Shared.DataContracts.BoardGameGeekGames;


namespace BoardChitless.Tests.ResourceAccess.APIAccessor_boardgamegeek
{
    [TestClass]
    public class bggAPI_Tests
    {
        private TransactionScope _testTransactionScope;

        #region Properties
        private APIAccessor_boardgamegeek_BoardGame Target { get; set; }
        private GameFamily CreatedDataContractInstance { get; set; }
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

        //private GameFamily _record { get; set; }


        [TestInitialize]
        public void TestInitialize()
        {
            _testTransactionScope = new TransactionScope();

            Target = new APIAccessor_boardgamegeek_BoardGame();

        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _testTransactionScope.Dispose();
        }

        [TestMethod]
        public void API_BoardGame_Hello()
        {
            Assert.AreNotEqual("Hello", "World");
        }

        [TestMethod]
        public void API_BoardGame_GetBoardGame()
        {
            var rtn = Target.getBoardGame("822");
            string xml = rtn;
            var obj = xml.ParseXML<items>();
            var gameName = "";


            //This is more a test to make sure that BGG doesn't change their calls than accuracy of code.
            foreach (itemsItem element in obj.item)
            {
                foreach (object itm in element.Items)
                {
                    if (itm.GetType() == typeof(itemsItemName))
                    {
                        itemsItemName Name = (itemsItemName)itm;
                        if (Name.type == "primary")
                        {
                            gameName = Name.value;
                        }
                    }
                }
            }

            Assert.AreEqual("Carcassonne", gameName);
            Assert.IsNotNull(rtn);
            
        }

        [TestMethod]
        public void API_BoardGame_Search()
        {
            var rtn = Target.search("exploding");

            Assert.IsNotNull(rtn);

            string xml = rtn;
            var obj = xml.ParseXML<BoardChitless.Shared.DataContracts.BoardGameGeekSearch.items>();
            

            //Check to make sure it's well formed BGG XML
            Assert.IsInstanceOfType(obj, typeof(BoardChitless.Shared.DataContracts.BoardGameGeekSearch.items));

            
            

        }


    }
}
