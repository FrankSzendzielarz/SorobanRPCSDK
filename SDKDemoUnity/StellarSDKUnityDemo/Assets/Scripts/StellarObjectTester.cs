using Stellar;
using Stellar.RPC;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StellarObjectTester : MonoBehaviour
{
    [Header("Stellar Configuration")]
    [SerializeField] private string testnetUrl = "https://soroban-testnet.stellar.org";
    [SerializeField] private string secretSeed = "SAZEWZ7VSEMZI35JROGXVGLDH4XAFZHY6HB2MO3NQXOY6K5WFSSG7PRH";
    [SerializeField] private string recipientAccountId = "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T";

    [Header("Stellar Objects")]
    [SerializeField] private string testAccountPublicKey;
    [SerializeField] private AccountEntry accountEntry;
    [SerializeField] private MuxedAccount.KeyTypeEd25519 test;

    [Header("UI Bindings")]
    [SerializeField] private Button uiButton;
    [SerializeField] private Button uiBackButton;
    [SerializeField] private ButtonSpinner buttonSpinner;  


    private HttpClient httpClient;
    private StellarRPCClient sorobanClient;
    private AccountID recipientId;
    private AccountID testAccountId;
    private bool isProcessing = false;

    private async void Start()
    {
        var testAccount = MuxedAccount.FromSecretSeed(secretSeed);
        testAccountId = new AccountID(testAccount.XdrPublicKey);
        testAccountPublicKey = testAccount.AccountId;
        TMP_Text buttonText = uiButton.GetComponentInChildren<TMP_Text>();
        buttonText.text = $"<color=#000080>Click for Stellar account balance! \n\n<b><size=50%><color=#1E90FF>{testAccountPublicKey}";
    }

    private async Task InitializeStellarClient()
    {
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(testnetUrl);
        sorobanClient = new StellarRPCClient(httpClient);

        var testAccount = MuxedAccount.FromSecretSeed(secretSeed);
        testAccountId = new AccountID(testAccount.XdrPublicKey);
        testAccountPublicKey = testAccount.AccountId;

        var recipientAccount = MuxedAccount.FromAccountId(recipientAccountId);
        recipientId = recipientAccount.XdrPublicKey;

        Debug.Log($"Initialized Stellar client with test account: {testAccountId}");
    }

    private async Task GetAccountDetails()
    {
        try
        {
            buttonSpinner.Flip();
            var result = await GetAccountLedgerEntryUseCase(sorobanClient, testAccountId);
            
            
            accountEntry = result;
            TMP_Text buttonText = uiBackButton.GetComponentInChildren<TMP_Text>();
            buttonText.text = $"<color=#000080>Your balance is {result.balance.InnerValue}!";


            Debug.Log($"Successfully retrieved account details");
            Debug.Log($"Balance {result.balance.InnerValue}");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error getting account details: {e.Message}");
            Debug.LogError($"Stack trace: {e.StackTrace}");
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

    public async void TestAccountDetails()
    {
        if (isProcessing)
        {
            Debug.Log("Already processing a request...");
            return;
        }

        try
        {
            isProcessing = true;
            Debug.Log("Starting account test...");

            using (httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(testnetUrl);
                sorobanClient = new StellarRPCClient(httpClient);

                await InitializeStellarClient();
                await GetAccountDetails();
            }
            Debug.Log("Account test completed successfully!");
        }
        catch (Exception e)
        {
            Debug.LogError($"Test failed: {e.Message}\nStack trace: {e.StackTrace}");
        }
        finally
        {
            isProcessing = false;
            httpClient?.Dispose();
            httpClient = null;
        }
    }
}