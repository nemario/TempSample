using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontPanic.Helpers;

namespace BoardChitless.Shared.ClientFactory
{
    public static class ClientFactory
    {
        private static ProxyFactory _factory;

        public static I Proxy<I>() where I : class
        {
            if (_factory == null)
            {
                _factory = new ProxyFactory();
            }

            return _factory.Proxy<I>();
        }

        public static void AddOverride<I, J>()
            where I : class
            where J : I, new()
        {
            if (_factory == null)
            {
                _factory = new ProxyFactory();
            }

            _factory.AddProxyOverride<I, J>(new J());
        }
    }
}

