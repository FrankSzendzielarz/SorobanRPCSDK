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
            PublicKey_PUBLIC_KEY_TYPE_ED25519 testAccountPubKey = new PublicKey_PUBLIC_KEY_TYPE_ED25519()
            {
                ed25519 = new uint256(keyPair.PublicKey)
            };
            AccountID testAccountId = new AccountID(testAccountPubKey);

            // Get health
            var healthResult = await sorobanClient.GetHealthAsync();

            // Get account
            LedgerKey myAccount = new LedgerKey_ACCOUNT()
            {
                account = new LedgerKey.accountStruct()
                {
                    accountID = testAccountId
                }
            };
            //TODO - think of some way of making encoding and decoding easier
            string encodedAccount;
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerKeyXdr.Encode(writer, myAccount);
                //Eg: above we can in codegen add a EncodeToBase64 string method that references LedgerKeyXdr
                writer.Flush();
                encodedAccount = Convert.ToBase64String(memoryStream.ToArray());
            }

            var accountLedgerEntriesArgument = new GetLedgerEntriesParams()
            {
                Keys = [encodedAccount]
            };
            var ledgerEntriesAccount = await sorobanClient.GetLedgerEntriesAsync(accountLedgerEntriesArgument);

            var test = ledgerEntriesAccount.Entries.First().LedgerEntryData;

        }
    }

    
}
