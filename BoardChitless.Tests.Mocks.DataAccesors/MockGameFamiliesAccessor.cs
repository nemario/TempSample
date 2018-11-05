using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using BoardChitless.Shared.Contracts;
using BoardChitless.Shared.DataContracts;
using BoardChitless.Tests.Common;

namespace BoardChitless.Tests.Mocks.DataAccesors
{
    public class MockGameFamiliesAccessor : IGameFamiliesAccessor
    {

        private GameFamily _record { get; set; }

        private void InitRecords()
        {
            _record = Staging.CreateTestGameFamily();
        }

        public GameFamily Create(GameFamily I)
        {
            I.gameFamilyID = 1;
            return I;
        }

        public GameFamily Find(long IId)
        {
            InitRecords();
            _record.gameFamilyID = IId;
            return _record;

        }
        public GameFamily UpdateOrCreate(GameFamily I)
        {
            if(I.gameFamilyID == 0) { I.gameFamilyID = 1; }
            return I;
        }


        public string TestMe(string input)
        {
            throw new NotImplementedException();
        }

    }
}
