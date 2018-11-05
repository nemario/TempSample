using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DontPanic.Helpers;
using System.ServiceModel;
using BoardChitless.Shared.DataContracts;

namespace BoardChitless.Shared.Contracts
{
    public interface IGameFamiliesAccessor
    {

        [OperationContract]
        string TestMe(string input);

        [OperationContract]
        GameFamily Create(GameFamily I);

        [OperationContract]
        GameFamily Find(long IId);

        [OperationContract]
        GameFamily UpdateOrCreate(GameFamily I);


    }
}
