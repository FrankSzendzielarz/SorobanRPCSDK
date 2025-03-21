﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Stellar.RPC
{
    [ServiceContract(Name = "Stellar")]
    public interface IStellarRPCClient
    {
        Task<GetEventsResult> GetEventsAsync(GetEventsParams parameters = null);
        Task<GetFeeStatsResult> GetFeeStatsAsync();
        Task<GetHealthResult> GetHealthAsync();
        Task<GetLatestLedgerResult> GetLatestLedgerAsync();
        Task<GetLedgerEntriesResult> GetLedgerEntriesAsync(GetLedgerEntriesParams parameters = null);
        Task<GetNetworkResult> GetNetworkAsync();
        Task<GetTransactionResult> GetTransactionAsync(GetTransactionParams parameters = null);
        Task<GetTransactionsResult> GetTransactionsAsync(GetTransactionsParams parameters = null);
        Task<GetVersionInfoResult> GetVersionInfoAsync();
        Task<SendTransactionResult> SendTransactionAsync(SendTransactionParams parameters = null);
        Task<SimulateTransactionResult> SimulateTransactionAsync(SimulateTransactionParams parameters = null);
    }


    public partial class StellarRPCClient : IStellarRPCClient
    {
        private HttpClient GetClient()
        {
            var client = this._httpClientFactory.CreateClient("StellarClient");
            if (string.IsNullOrEmpty(client.BaseAddress?.ToString()) && !string.IsNullOrEmpty(Network.Url))
            {
                client.BaseAddress = new Uri(Network.Url);
                Console.WriteLine($"Setting client BaseAddress to: {client.BaseAddress}");
            }
            return client;
        }

    }
}
