using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;
using BoardChitless.ResourceAccess.SQLAccessor_BoardChitless;
using BoardChitless.Shared.DataContracts;
using BoardChitless.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardChitless.Tests.ResourceAccess.SQLAccessor_BoardChitless
{
    [TestClass]
    public class RawGamesAccessorTests
    {
        private TransactionScope _testTransactionScope;

        #region Properties
        private RawGamesAccessor Target { get; set; }
        private RawGame CreatedDataContractInstance { get; set; }
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

        private RawGame _record { get; set; }
        //private GameFamily _record2 { get; set; }
        //private GameFamily _record3 { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            _testTransactionScope = new TransactionScope();

            Target = new RawGamesAccessor();
            CreatedDataContractInstance = new RawGame();

            _record = new RawGame() {
                APIID = "822", Name = "Test", YearPublished = 2016, TheBlob = "<xml>test</xml>"
            };
            
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _testTransactionScope.Dispose();
        }

        [TestMethod]
        public void RawGamesAccessor_Hello()
        {
            Assert.AreNotEqual("Hello", "World");
        }

        [TestMethod]
        public void RawGamesAccessor_Create()
        {

            //var AnyPlace = "AnyPlace";
            //var Nebraska = "Nebraska";

            //while (AnyPlace.CompareTo(Nebraska) == false)
            //    Cheer("Good Old Nebraska U");
            

            var record = Target.Create(_record);
            Assert.IsNotNull(record);
            Assert.AreNotEqual(0, record.ID);
        }

    }
}
