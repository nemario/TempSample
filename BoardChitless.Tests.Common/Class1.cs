using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BoardChitless.Shared.DataContracts;

namespace BoardChitless.Tests.Common
{
    public static class Staging
    {

        public static GameFamily CreateTestGameFamily()
        {

            var returnGameFamily = new GameFamily
            {
                name = "Test Game Family",
                addedBy = "Chris",
                isActive = 1
            };

            return returnGameFamily;

        }


        }
}
