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
    public class GameFamilyAccessorTests
    {
        private TransactionScope _testTransactionScope;

        #region Properties
        private GameFamiliesAccessor Target { get; set; }
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

        private GameFamily _record { get; set; }
        //private GameFamily _record2 { get; set; }
        //private GameFamily _record3 { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            _testTransactionScope = new TransactionScope();

            Target = new GameFamiliesAccessor();
            CreatedDataContractInstance = new GameFamily();

            _record = Staging.CreateTestGameFamily();
            
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _testTransactionScope.Dispose();
        }

        [TestMethod]
        public void GameFamilyAccessor_Hello()
        {
            Assert.AreNotEqual("Hello", "World");
        }

        [TestMethod]
        public void GameFamilyAccessor_Create()
        {
            var gameFamily = Target.Create(_record);
            Assert.IsNotNull(gameFamily);
            Assert.AreNotEqual(0, gameFamily.gameFamilyID);
        }

    }
}
