using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontPanic.Helpers;

namespace BoardChitless.Shared.ApiServiceBase
{
    public class ApiServiceBase : ServiceBase
    {
        public virtual string TestMe(string input)
        {
            return string.Format("{0}, {1}", input, this.GetType().Name);
        }
    }
}
