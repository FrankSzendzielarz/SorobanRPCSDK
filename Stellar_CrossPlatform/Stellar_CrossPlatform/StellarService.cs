using Stellar;
using Stellar.RPC;
namespace Stellar_CrossPlatform.Services
{
    public class StellarService 
    {
        private const string StellarKeyAlias = "STELLAR_SK";
        private ISecureStorage _secureStorage;
        private HttpClient _httpClient;
        private StellarRPCClient _sorobanClient;

        public StellarService()
        {
            _secureStorage = SecureStorage.Default;
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(3000);
            _httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            var httpClientFactory = new SimpleHttpClientFactory(_httpClient);
            _sorobanClient = new StellarRPCClient(httpClientFactory);
        }

        public async Task ResetAccount()
        {
            try
            {
                _secureStorage.Remove(StellarKeyAlias);
            }
            catch
            {
                // nothing
            }
        }

        public async Task<MuxedAccount.KeyTypeEd25519> GetAccount()
        {
            try
            {
                MuxedAccount.KeyTypeEd25519 account;

                // Check if secure storage has our key
                string storedKey = await _secureStorage.GetAsync(StellarKeyAlias);

                if (!string.IsNullOrEmpty(storedKey))
                {
                    // If yes, return the account
                    byte[] seed = Convert.FromBase64String(storedKey);
                    account = MuxedAccount.FromSecretSeed(seed);
                }
                else
                {
                    account = MuxedAccount.Random();
                    await _secureStorage.SetAsync(StellarKeyAlias, Convert.ToBase64String(account.SeedBytes));
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

        private async Task<AccountEntry> GetAccountLedgerEntry(AccountID testAccountId)
        {
            // Your existing implementation
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

    // HttpClientFactory can remain the same
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
