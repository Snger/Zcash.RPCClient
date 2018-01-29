﻿using System;
using System.Collections.Generic;
using Timemicro.Zcash.RPCClient;
using Timemicro.Zcash.RPCClient.Methods;

namespace TimemicroCore.Zcash.RPCClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(new GetBalanceParams() { Account = "mattf"});

            JsonRPCClient client = new JsonRPCClient("http://192.168.1.115:18232", "Ulysses", "pwd123456");
            
            /*
           var resp0 = client.Call<GetNewAddressResponse>(JsonRPCMethods.GetNewAddress, new GetNewAddressParams());
           Console.WriteLine(resp0);

           var resp1 = client.Call<GetBalanceResponse>(JsonRPCMethods.GetBalance, new GetBalanceParams());
           Console.WriteLine(resp1);

           var resp2 = client.Call<GetBestBlockHashResponse>(JsonRPCMethods.GetBestBlockHash, new GetBestBlockHashParams() );
           Console.WriteLine(resp2);

           var resp3 = client.Call<GetBlockResponse>(JsonRPCMethods.GetBlock, new GetBlockParams() { HeaderHash = resp2.Result });
           Console.WriteLine(resp3);

           var resp4 = client.Call<GetChainTipsResponse>(JsonRPCMethods.GetChainTips, new GetChainTipsParams());
           Console.WriteLine(resp4);

           var resp5 = client.Call<GetRawTransactionResponse>(JsonRPCMethods.GetRawTransaction, new GetRawTransactionParams()
           {
               TxId = resp3.Result.Tx[0]
           });
           Console.WriteLine(resp5);
           */

            /*
            var resp7 = client.Call<WalletPassphraseResponse>(JsonRPCMethods.WalletPassphrase, new WalletPassphraseParams()
            {
                Passphrase = "fslong25!@#",
                Seconds = 30
            });
            Console.WriteLine(resp7);

            var resp8 = client.Call<SetTxFeeResponse>(JsonRPCMethods.SetTxFee, new SetTxFeeParams()
            {
                TransactionFeePerKilobyte = 0.003m
            });
            Console.WriteLine(resp8);

            var resp6 = client.Call<SendManyResponse>(JsonRPCMethods.SendMany, new SendManyParams()
            {
                FromAccount = "testnet",
                Outputs = new Dictionary<string, decimal>()
                {
                    { "n2bypZoP7QuNHBvSq5QUT11ccMQJ2ZCajy", 0.0001m }
                },
                Confirmations = 1,
                Comment = "testsendmany"
            });
            Console.WriteLine(resp6);
            */

            var resp9 = client.Call<ListUnspentResponse>(JsonRPCMethods.ListUnspent, new ListUnspentParams()
            {

            });
            Console.WriteLine(resp9);

            var resp10 = client.Call<ListUnspentResponse>(JsonRPCMethods.ListUnspent, new ListUnspentParams()
            {
                Addresses = new List<string>() { "myuuAQtmqBNHC9iYeUke1nCn1kV6NPK2QT" }
            });
            Console.WriteLine(resp10);
        }
    }
}
