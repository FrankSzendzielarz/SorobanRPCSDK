# Stellar RPC SDK for Unity

This guide explains how to integrate the Stellar RPC SDK into Unity projects, enabling your games and applications to interact with the Stellar blockchain network.

## Why Integrate Stellar into Your Unity Games?

Adding blockchain functionality to your Unity projects opens up exciting new possibilities:

### In-Game Economies
- **True Digital Ownership**: Let players truly own their in-game items as blockchain assets
- **Cross-Game Assets**: Enable items to transfer between different games in your ecosystem
- **Player-Driven Marketplaces**: Create economies where players can trade directly with each other
- **Real Value**: Allow items to have real-world value through connection to the broader Stellar ecosystem

### Player Rewards
- **Tokenized Achievements**: Reward player accomplishments with tokens that have real utility
- **Play-to-Earn Mechanics**: Implement sustainable play-to-earn models
- **Loyalty Programs**: Create cross-game loyalty systems with blockchain-based points

### Innovative Gameplay
- **Verifiable Random Rewards**: Use blockchain for provably fair loot drops
- **Persistent World State**: Store critical game state on-chain for true persistence
- **Decentralized Governance**: Allow players to vote on game changes using tokens

### Technical Benefits
- **Low Fees**: Stellar's minimal transaction costs make microtransactions viable
- **Fast Transactions**: Near-instant finality for smooth player experiences
- **Energy Efficient**: Stellar's consensus protocol is environmentally friendly
- **Cross-Platform Consistency**: Same blockchain state across all platforms
- **Smart Contracts**: Leverage Soroban smart contracts for complex game logic

## Installation

The Stellar RPC SDK Unity package is available through GitHub releases. To add it to your project:

1. Download the `StellarRPCSDK.Unity.dll` from the [GitHub releases page](https://github.com/yourusername/stellar-rpcsdk/releases)
2. Create a `Plugins` folder in your Unity project's Assets directory if it doesn't already exist
3. Place the downloaded DLL in the Plugins folder
4. The SDK will now be available to use in your Unity scripts

### SDK Package Features

The Unity version of the SDK includes several optimizations:

- **Internalized Assemblies**: Dependencies are internalized to prevent conflicts with other Unity packages
- **Editor Visibility**: All Stellar XDR-based classes and RPC classes are properly decorated for visibility in the Unity editor
- **Newtonsoft JSON**: Uses Newtonsoft.Json for compatibility with Unity's serialization system
- **Unity Thread Handling**: Properly manages thread transitions between Unity's main thread and background operations

## Using the SDK in Unity

The SDK allows you to interact with the Stellar network through C# scripts in your Unity project.

### Basic Setup

Here's how to initialize the SDK in your Unity project:

```csharp
using Stellar;
using Stellar.RPC;
using System;
using System.Net.Http;
using UnityEngine;

public class StellarManager : MonoBehaviour
{
    private HttpClient httpClient;
    private StellarRPCClient stellarClient;
    
    void Awake()
    {
        // Initialize the client with the Stellar testnet
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
        stellarClient = new StellarRPCClient(httpClient);
        
        // Set the network to testnet
        Network.UseTestNetwork();
    }
    
    void OnDestroy()
    {
        // Clean up resources
        httpClient?.Dispose();
    }
}
```

## Demo Project Highlights

The `SDKDemoUnity` project demonstrates several key features of the Stellar RPC SDK in Unity.

### StellarObjectTester

The `StellarObjectTester` script shows how to:

1. **Initialize the SDK**: Set up the necessary clients and network configuration
2. **Connect to Accounts**: Work with Stellar accounts using secret seeds or public keys
3. **Retrieve Account Details**: Query the Stellar network for account information
4. **Handle UI Integration**: Connect blockchain operations to Unity UI elements

Key code snippets:

```csharp
// Retrieve account information from the ledger
private static async Task<AccountEntry> GetAccountLedgerEntryUseCase(
    StellarRPCClient sorobanClient, 
    AccountID testAccountId)
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
```

### ButtonSpinner

The `ButtonSpinner` component demonstrates a UI pattern for providing visual feedback during blockchain operations, which can sometimes take a moment to complete:

```csharp
public void Flip()
{
    if (!isRotating)
    {
        StartCoroutine(RotateButton());
    }
}

private IEnumerator RotateButton()
{
    // Visual feedback animation during blockchain operations
    isRotating = true;
    float elapsed = 0;
    float startY = transform.eulerAngles.y;
    float endY = startY + 180f;

    while (elapsed < rotationDuration)
    {
        elapsed += Time.deltaTime;
        float percentage = elapsed / rotationDuration;

        // Use smoothstep for more natural rotation
        float smoothProgress = percentage * percentage * (3f - 2f * percentage);
        float currentY = Mathf.Lerp(startY, endY, smoothProgress);
        transform.eulerAngles = new Vector3(0, currentY, 0);

        // Flip text visibility halfway through
        if (percentage >= 0.5f && !isBackVisible)
        {
            frontButton.gameObject.SetActive(false);
            backButton.gameObject.SetActive(true);
            isBackVisible = true;
        }

        yield return null;
    }

    isRotating = false;
}
```

## Best Practices for Unity Integration

When integrating the Stellar RPC SDK with Unity, keep these best practices in mind:

### Threading
Unity is not thread-safe, and most blockchain operations are asynchronous. Always:
- Use `UnityMainThreadDispatcher` or similar to return to the main thread when updating UI
- Consider using Unity's Coroutine system for workflow management
- Handle exceptions properly to prevent background threads from crashing silently

```csharp
// Example of proper thread handling
public async void PerformBlockchainOperation()
{
    try
    {
        // Show loading indicator
        loadingIndicator.SetActive(true);
        
        // Perform blockchain operation on background thread
        var result = await GetAccountDetails();
        
        // Update UI on main thread
        UnityMainThreadDispatcher.Instance().Enqueue(() => {
            balanceText.text = result.balance.ToString();
            loadingIndicator.SetActive(false);
        });
    }
    catch (Exception e)
    {
        // Handle errors on main thread
        UnityMainThreadDispatcher.Instance().Enqueue(() => {
            errorText.text = "Error: " + e.Message;
            loadingIndicator.SetActive(false);
        });
    }
}
```

### Resource Management
- Keep network operations efficient to avoid impacting game performance
- Implement caching for frequently accessed blockchain data
- Dispose of HttpClient properly when your game/scene unloads
- Consider connection pooling for high-frequency operations

### Security
- Never hardcode private keys in your game
- Use Unity's `PlayerPrefs` with encryption or a secure storage solution for sensitive data
- Implement proper authentication for any server-side components
- Consider a custody solution for managing user keys in production games

### User Experience
- Always provide visual feedback during blockchain operations
- Implement retry logic for network failures
- Cache data locally to provide offline functionality when possible
- Design your UI to handle the asynchronous nature of blockchain interactions

## Advanced Integration Scenarios

### Asset Tokenization
For representing in-game items as tokens on Stellar.


### Smart Contract Integration
For complex game logic using Soroban smart contracts. Please see the tutorials section for Soroban invocation.


## Conclusion

Integrating the Stellar RPC SDK into your Unity project opens up powerful blockchain capabilities with relatively little effort. The optimized Unity package handles the complex blockchain interactions while allowing you to focus on creating engaging gameplay experiences enhanced by true digital ownership, cross-game assets, and player-driven economies.

Whether you're building a full blockchain game or just adding token rewards to your existing project, the Stellar ecosystem offers the performance, low fees, and developer-friendly tools to make your vision a reality.

For more complex examples and advanced usage, refer to the complete SDKDemoUnity project or explore the other platform-specific guides in this documentation.