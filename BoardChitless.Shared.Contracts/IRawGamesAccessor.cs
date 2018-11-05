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
    public interface IRawGamesAccessor
    {

        [OperationContract]
        string TestMe(string input);

        [OperationContract]
        RawGame Create(RawGame I);

        [OperationContract]
        RawGame Find(long IId);

        RawGame FindByAPIKey(string Key);

        [OperationContract]
        RawGame UpdateOrCreate(RawGame I);

    }
}
