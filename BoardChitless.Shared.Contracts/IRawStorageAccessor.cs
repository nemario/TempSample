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
    public interface IRawStorageAccessor
    {

        [OperationContract]
        string TestMe(string input);

        [OperationContract]
        rawStorage Create(rawStorage I);

        [OperationContract]
        rawStorage Find(long IId);

        [OperationContract]
        rawStorage UpdateOrCreate(rawStorage I);

    }
}
