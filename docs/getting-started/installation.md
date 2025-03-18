# Installation Guide

This guide covers how to install the Stellar RPC SDK for different platforms and project types.

## .NET Console/Web Applications

For standard .NET applications, the SDK is available as a NuGet package:

```bash
# Using the .NET CLI
dotnet add package StellarRPCSDK

# Using the Package Manager Console in Visual Studio
Install-Package StellarRPCSDK
```

Alternatively, you can add the package reference directly to your `.csproj` file:

```xml
<ItemGroup>
  <PackageReference Include="StellarRPCSDK" Version="1.0.0" />
</ItemGroup>
```

## Platform-Specific Installations

### Unity

For Unity projects:

1. Open your Unity project
2. Navigate to **Window > Package Manager**
3. Click the **+** button and select **Add package from git URL...**
4. Enter the package URL: `https://github.com/yourusername/stellar-rpcsdk-unity.git#v1.0.0`

Alternatively, download the Unity package from our [GitHub Releases](https://github.com/yourusername/stellar-rpcsdk/releases) and import it into your project.

### MAUI/Xamarin

For MAUI or Xamarin applications:

```bash
# Using the .NET CLI
dotnet add package StellarRPCSDK.Mobile

# Using the Package Manager Console in Visual Studio
Install-Package StellarRPCSDK.Mobile
```

### Tizen

For Tizen applications, add the following to your `.csproj` file:

```xml
<ItemGroup>
  <PackageReference Include="StellarRPCSDK.Tizen" Version="1.0.0" />
</ItemGroup>
```

### Native Applications

For native applications such Unreal Engine, Go, Rust and so on:

1. Download the appropriate binary from our [GitHub Releases](https://github.com/yourusername/stellar-rpcsdk/releases)
2. Follow our [Native Platform](../platforms/native.md) guidance

## Verifying the Installation

To verify that the SDK is correctly installed:

```csharp
using Stellar.RPC;

// Create a client instance
var client = new StellarRPCClient("https://soroban-testnet.stellar.org");

// Check connection to the server
var health = await client.GetHealthAsync();
Console.WriteLine($"Connected to Stellar network, latest ledger: {health.LatestLedger}");
```

## Framework Requirements

- .NET 8.0 or higher
- Unity 2021.3 or higher (for Unity package)
- MAUI 7.0 or higher (for MAUI package)
- Tizen 6.5 or higher (for Tizen package)

## Next Steps

Once you have installed the SDK, you can:

- Continue with the [Quick Start Tutorial](quickstart.md)
- Learn about [Setting Up Stellar Accounts](accounts-setup.md)
- Explore specific [Use Case Tutorials](../tutorials/index.md)