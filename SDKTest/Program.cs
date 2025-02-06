using Stellar;
using Stellar.RPC;
using Stellar.XDR;
using System.Net.Http.Headers;

namespace SDKTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
          
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
            StellarRPCClient sorobanClient = new StellarRPCClient(httpClient);

            // Set up a test account
            KeyPair keyPair = KeyPair.FromAccountId("GA3RQ7FWMT6INHS2R4KEKWENPYQOPLRNPYDAJFFRY5AUSD2GP6VG3OPY");
            PublicKey.PublicKeyTypeEd25519 testAccountPubKey = new PublicKey.PublicKeyTypeEd25519()
            {
                ed25519 = keyPair.PublicKey
            };
            AccountID testAccountId = testAccountPubKey;

            // Get health
            var healthResult = await sorobanClient.GetHealthAsync();

            // Get account
            LedgerKey myAccount = new LedgerKey.Account()
            {
                account = new LedgerKey.accountStruct() //TODO - this is an artifact of the XDR where unnecessary structs are added into union case arms.
                {
                    accountID = testAccountId
                }
            };

            var encodedAccount = LedgerKeyXdr.EncodeToBase64(myAccount);
      
            var accountLedgerEntriesArgument = new GetLedgerEntriesParams()
            {
                Keys = [encodedAccount]
            };
            var ledgerEntriesAccount = await sorobanClient.GetLedgerEntriesAsync(accountLedgerEntriesArgument);

            var test = ledgerEntriesAccount.Entries.First().LedgerEntryData as LedgerEntry.dataUnion.Account;


            PaymentOp paymentOp = new PaymentOp();
            paymentOp.asset = new Asset.AssetTypeNative();

        }
    }

    
}
