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
    public class RawStorageAccessorTests
    {
        private TransactionScope _testTransactionScope;

        #region Properties
        private rawStorageAccessor Target { get; set; }
        private rawStorage CreatedDataContractInstance { get; set; }
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

        private rawStorage _record { get; set; }
        //private GameFamily _record2 { get; set; }
        //private GameFamily _record3 { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            _testTransactionScope = new TransactionScope();

            Target = new rawStorageAccessor();
            CreatedDataContractInstance = new rawStorage();

            _record = Staging.CreateTestRawStorage();
            
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            _testTransactionScope.Dispose();
        }

        [TestMethod]
        public void RawStorageAccessor_Hello()
        {
            Assert.AreNotEqual("Hello", "World");
        }

        [TestMethod]
        public void RawStorageAccessor_Create()
        {
            var record = Target.Create(_record);
            Assert.IsNotNull(record);
            Assert.AreNotEqual(0, record.rawStorageID);
        }

    }
}
