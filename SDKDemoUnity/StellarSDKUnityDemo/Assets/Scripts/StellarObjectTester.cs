using Stellar;
using Stellar.RPC;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

public class StellarObjectTester : MonoBehaviour
{
    [Header("Stellar Configuration")]
    [SerializeField] private string testnetUrl = "https://soroban-testnet.stellar.org";
    [SerializeField] private string secretSeed = "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH";
    [SerializeField] private string recipientAccountId = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T";

    [Header("Stellar Objects")]
    [SerializeField, SerializeReference] private AccountID testAccountId;
    [SerializeField] private AccountID recipientId;
    [SerializeField] private AccountEntry accountEntry;

    private HttpClient httpClient;
    private StellarRPCClient sorobanClient;

    private async void Start()
    {
        try
        {
            await InitializeStellarClient();
            await GetAccountDetails();
        }
        catch (Exception e)
        {
            Debug.LogError($"Error in Stellar initialization: {e.Message}");
        }
    }

    private async Task InitializeStellarClient()
    {
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(testnetUrl);
        sorobanClient = new StellarRPCClient(httpClient);

        var testAccount = MuxedAccount.FromSecretSeed(secretSeed);
        testAccountId = new AccountID(testAccount.XdrPublicKey);

        var recipientAccount = MuxedAccount.FromAccountId(recipientAccountId);
        recipientId = recipientAccount.XdrPublicKey;

        Debug.Log($"Initialized Stellar client with test account: {testAccountId}");
    }

    private async Task GetAccountDetails()
    {
        try
        {
            accountEntry = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            Debug.Log($"Successfully retrieved account details");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error getting account details: {e.Message}");
        }
    }

    private static async Task<AccountEntry> GetAccountLedgerEntryUseCase(StellarRPCClient sorobanClient, AccountID testAccountId)
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
            Keys = new[] { encodedAccount }
        };
        var ledgerEntriesAccount = await sorobanClient.GetLedgerEntriesAsync(accountLedgerEntriesArgument);
        var test = ledgerEntriesAccount.Entries.First().LedgerEntryData as LedgerEntry.dataUnion.Account;
        return test.account;
    }

    private void OnDestroy()
    {
        httpClient?.Dispose();
    }

    // You might want to add a public method to call from a UI button
    public async void RefreshAccountDetails()
    {
        await GetAccountDetails();
    }
}