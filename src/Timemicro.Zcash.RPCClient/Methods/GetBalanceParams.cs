﻿using System;
namespace Timemicro.Zcash.RPCClient.Methods
{
    public class GetBalanceParams : JsonRPCRequestParams
    {
        public GetBalanceParams()
        {
            Account = string.Empty;
        }

        public string Account { get { return Get<string>(0); } set { Set(0, value); } }
    }
}
