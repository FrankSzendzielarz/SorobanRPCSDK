# Installation Guide

This guide covers how to install the Stellar RPC SDK for different platforms and project types.

Releases can be found in the [releases](https://github.com/FrankSzendzielarz/SorobanRPCSDK/releases) pages of 
the GitHub repository as a ***zip file***.

## .NET Console/Web Applications

For standard .NET applications, the SDK is available as a NuGet package.

Until the NuGet is published on Nuget.org, use the **StellarRPCSDK.[version].nupkg** in a local source.

When the NuGet is available on Nuget.org, use these commands.

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

## Using with Dependency Injection

The Stellar RPC SDK is designed to work with dependency injection systems. The `StellarRPCClient` requires an `IHttpClientFactory` implementation.

### In ASP.NET Core applications

```csharp
// In Program.cs or Startup.cs
builder.Services.AddHttpClient("StellarClient", client =>
{
    client.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
});

builder.Services.AddScoped<StellarRPCClient>(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    return new StellarRPCClient(httpClientFactory);
});
```

### In Console Applications

For simple console applications without dependency injection, you can use a simple implementation:

```csharp
// A simple HTTP client factory for console applications
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

// Usage
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://soroban-testnet.stellar.org");
var httpClientFactory = new SimpleHttpClientFactory(httpClient);
StellarRPCClient client = new StellarRPCClient(httpClientFactory);
```

Note that this simple implementation is provided as a convenience for example code and simple applications. For production applications, a proper dependency injection system is recommended.

## Platform-Specific Installations

### Unity

For Unity projects:

Download the Unity package from our [GitHub Releases](https://github.com/FrankSzendzielarz/SorobanRPCSDK/releases) and import the
**StellarRPCSDK.dll** and **StellarRPCSDK.pdb** into your project.

### MAUI Cross Platform Native

For MAUI applications target .NET 8 and follow the same instructions for .NET.

### Tizen

For Tizen applications, use the NuGet package from the Tizen folder of the release zip.


### Native  Applications

For native applications:

1. Download the appropriate binary from our [GitHub Releases](https://github.com/FrankSzendzielarz/SorobanRPCSDK/releases)
2. See the tutorials for further instructions to
    1. Load the library
    2. Start it
    3. Create gRPC clients and invoke them.

Also see the Rust example [here](https://github.com/FrankSzendzielarz/SorobanRPCSDK/tree/main/StellarRPCSDK_Native/native_client_tests/rust_client) for examples of
how to use the binary for your platform.


## Next Steps

Once you have installed the SDK, you can:

- Continue with the [Quick Start Tutorial](quickstart.md)
- Learn about [Setting Up Stellar Accounts](accounts-setup.md)
- Explore specific [Use Case Tutorials](../tutorials/index.md)