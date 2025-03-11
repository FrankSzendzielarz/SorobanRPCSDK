using Stellar;
using Stellar.RPC;
using Stellar_Tizen.Models;
using Stellar_Tizen.Tizen.TV.SecureStorage;
using Stellar_Tizen.Tizen.TV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(StellarService))]
namespace Stellar_Tizen.Tizen.TV.Services
{

    public class StellarService : IStellarService
    {
        private const string StellarKeyAlias = "STELLAR_SK";

        private Data _data;

        private HttpClient _httpClient;
        private StellarRPCClient _sorobanClient;



        public StellarService()
        {
            _data = new Data();
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(3000);               //for debugging
            _httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(_httpClient);
            _sorobanClient = new StellarRPCClient(httpClientFactory);

        }



        public async Task ResetAccount()
        {
            try
            {
                MuxedAccount account;
                //check if secure storage has our key.
                if (_data.Exists(StellarKeyAlias))
                {
                    _data.Remove(StellarKeyAlias);
                }


            }
            catch
            {
                //nothing
            }

        }

        public async Task<MuxedAccount.KeyTypeEd25519> GetAccount()
        {
            try
            {
                MuxedAccount.KeyTypeEd25519 account;
                //check if secure storage has our key.
                if (_data.Exists(StellarKeyAlias))
                {
                    //if yes, return the account.
                    byte[] seed = _data.Get(StellarKeyAlias);
                    account = MuxedAccount.FromSecretSeed(seed);  //In a production setting copy the pk and dispose the old KP
                }
                else
                {
                    account = MuxedAccount.Random();         //In a production setting copy the pk and dispose the old KP
                    _data.Save(account.SeedBytes, StellarKeyAlias);
                }
                return account;
            }
            catch
            {
                return null;
            }

        }

        public async Task<long> GetBalance(MuxedAccount.KeyTypeEd25519 account)
        {
            AccountID accountId = new AccountID(account.XdrPublicKey);
            AccountEntry entry = await GetAccountLedgerEntry(accountId);
            if (entry != null)
                return entry.balance;
            else
                return 0;
        }
    
        private async Task<AccountEntry> GetAccountLedgerEntry( AccountID testAccountId)
        {
            LedgerKey myAccount = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = testAccountId
                }
            };
            var encodedAccount = LedgerKeyXdr.EncodeToBase64(myAccount);
            var accountLedgerEntriesArgument = new GetLedgerEntriesParams()
            {
                Keys = new List<string>() { encodedAccount }
            };
            var ledgerEntriesAccount = await _sorobanClient.GetLedgerEntriesAsync(accountLedgerEntriesArgument);
            var test = ledgerEntriesAccount.Entries.FirstOrDefault()?.LedgerEntryData as LedgerEntry.dataUnion.Account;
        
            return test?.account;
        }




    }

    public class SimpleHttpClientFactory : IHttpClientFactory
    {
        private readonly HttpClient _httpClient;

        public SimpleHttpClientFactory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public HttpClient CreateClient(string name)
        {
            return _httpClient;
        }
    }
}
