# Native Bindings for Stellar RPC SDK

This guide explains how to use the Stellar RPC SDK's native bindings, which allow developers to integrate Stellar network functionality into applications written in languages other than .NET.

## Architecture Overview

The Stellar RPC SDK native bindings employ an innovative architecture that combines the power of .NET native AOT compilation with the flexibility of gRPC:

1. **Native AOT Binaries**: The SDK is compiled using .NET's Ahead-of-Time (AOT) compilation and aggressive trimming, resulting in compact, efficient native binaries for various platforms.

2. **Embedded gRPC Server**: Each binary contains an embedded gRPC server that runs in-process, providing a high-performance interface to the SDK's functionality.

3. **Proto-based Interface**: Communication with the native binary happens via Protocol Buffers (proto) definitions, making the SDK accessible from virtually any programming language that supports gRPC.

4. **Cross-Platform Support**: Binaries are available for multiple platforms including Windows, Linux, and macOS, in both x64 and ARM64 variants.

This architecture enables developers to use the Stellar RPC SDK from any programming environment, including game engines like Unreal Engine, systems programming languages like Rust, and other ecosystems like Go, Python, or JavaScript.

## Getting Started

### Prerequisites

- Native Stellar RPC SDK binary for your platform (from GitHub releases)
- Proto files for the gRPC interface (included with the binaries)
- A gRPC client library for your programming language

### Binary Distribution

The native binaries are available from the GitHub releases page for this repository. Each release includes:

- Windows (win-x64, win-arm64)
- Linux (linux-x64, linux-arm64)
- macOS (osx-x64, osx-arm64)

An example release is here https://github.com/FrankSzendzielarz/SorobanRPCSDK/releases/download/v0.0.3/stellar-sdk-native-v0.0.3.zip Note that the binary is the **sdk-native** not
the native-aot. The zip file contains the proto files in the proto folder.

For supported platforms, see the list in `StellarRPCSDK_Native/README.txt`:

```
'win-x64'
'win-arm64'
'linux-x64'
'linux-arm64'
'osx-x64'
'osx-arm64'
```

### Integration Approach

Integrating with the SDK involves:

1. Loading the native binary
2. Starting the embedded gRPC server
3. Connecting to the server via gRPC
4. Invoking SDK methods through the gRPC interface

Unlike direct .NET integration, where you would interact with a single client object, the native bindings expose each major class as a separate gRPC service. This provides a clean separation of concerns and allows for fine-grained access to SDK functionality.

## gRPC Service Structure

The native SDK exposes several gRPC services, each corresponding to a major class in the .NET SDK:

- **StellarClient**: The main client for interacting with the Stellar network
- **MuxedAccountProtoWrapper**: Operations for creating and managing Stellar accounts
- **NetworkProtoWrapper**: Network configuration operations
- **TransactionProtoWrapper**: Methods for working with transactions
- **SimulateTransactionResultProtoWrapper**: Functions for simulation results
- **XdrProtoService**: Utilities for XDR encoding/decoding

Each service provides methods that mirror the functionality of its .NET counterpart, adapted for the gRPC protocol.

## Example: Rust Client Integration

The repository includes a Rust client example in `StellarRPCSDK_Native/native_client_tests/rust_client` that demonstrates how to integrate with the SDK. Let's explore the key components:

### Project Setup

The Rust client uses:
- `tonic` for gRPC communication
- `libloading` for dynamically loading the native binary
- `tokio` for asynchronous runtime

The `build.rs` file compiles the proto definitions into Rust code:

```rust
fn main() -> Result<(), Box<dyn std::error::Error>> {
    tonic_build::configure()
        .build_client(true)
        .build_server(true)
        .compile(&["../../Stellar.proto", "../../Stellar.RPC.proto"], &["../../"])?;
    Ok(())
}
```

### Loading the Native Binary

The client loads the native binary using `libloading`:

```rust
// Load the C# DLL
let lib = unsafe { 
    Library::new("../../bin/NativeAOT/net8.0/win-x64/publish/StellarRPCSDK_Native.dll")?
};

// Start the server
let start_server: Symbol<unsafe extern "C" fn()> = unsafe { lib.get(b"StartServer")? };
unsafe { start_server() };
```

This starts the embedded gRPC server inside the native binary.

### Connecting to the Server

The client connects to the server using platform-specific IPC mechanisms:

```rust
#[cfg(target_os = "windows")]
let channel = Channel::from_static("http://localhost")
    .connect_with_connector(service_fn(|_: Uri| async move {
        ClientOptions::new()
            .open(r"\\.\pipe\MyServicePipe")
    }))
    .await?;
#[cfg(not(target_os = "windows"))]
let channel = Channel::from_static("http://localhost")
    .connect_with_connector(service_fn(|_: Uri| async move {
        tokio::net::UnixStream::connect("/tmp/MyService.sock")
    }))
    .await?;
```

On Windows, this connects to a named pipe, while on Linux/macOS it uses a Unix domain socket.

### Creating Client Instances

The client creates instances of the various gRPC services:

```rust
// Create both the RPC client and specialized clients
let mut network_client = NetworkProtoWrapperClient::new(channel.clone());
let mut stellar_client = StellarClient::new(channel.clone());
let mut muxed_client = MuxedAccountProtoWrapperClient::new(channel.clone());
let mut xdr_client = XdrProtoServiceClient::new(channel.clone());
let mut transaction_client = TransactionProtoWrapperClient::new(channel.clone());
```

### Configuring the Network

Before making API calls, the client configures the network:

```rust
// Configure network first
network_client.use_test_network(tonic::Request::new(())).await?;
network_client.set_url(tonic::Request::new(stellar::SetUrlParam {
    url: "https://soroban-testnet.stellar.org".to_string()
})).await?;
```

### Making API Calls

API calls are made through the appropriate client:

```rust
// Get health status
let health = stellar_client
    .get_health(tonic::Request::new(()))
    .await?;
println!("Health status: {:?}", health);

// Generate Muxed Account
let account = muxed_client
    .from_account_id(tonic::Request::new(stellar::StringWrapper {
        value: "GDVEUTTMKYKO3TEZKTOONFCWGYCQTWOC6DPJM4AGYXKBQLWJWE3PKX6T".to_string()
    }))
    .await?;
```

### Complex Operations Example: Retrieving Account Information

The example demonstrates how to retrieve account information, which requires several steps:

1. Create a MuxedAccount from an account ID
2. Get the public key
3. Create a LedgerKey for the account
4. Encode the LedgerKey using the XDR service
5. Get ledger entries using the RPC client
6. Process the response

```rust
// Get Public Key
let pk = muxed_client
    .get_public_key(tonic::Request::new(account.into_inner()))
    .await?;

// Create and encode ledger key 
let ledger_key = stellar::LedgerKey {
    subtype: Some(stellar::ledger_key::Subtype::LedgerKeyAccount(
        stellar::LedgerKeyAccount {
            account: Some(stellar::LedgerKeyAccountStruct {
                account_id: Some(stellar::AccountId {
                    inner_value: Some(stellar::PublicKey {
                        subtype: Some(stellar::public_key::Subtype::PublicKeyPublicKeyTypeEd25519(
                            stellar::PublicKeyPublicKeyTypeEd25519 {
                                ed25519: Some(stellar::Uint256 {
                                    inner_value: pk.into_inner().value,
                                }),
                            },
                        )),
                    }),
                }),
            }),
        },
    )),
};
let ledger_key_encode_request = stellar::LedgerKeyEncodeRequest {
    value: Some(ledger_key),
};

let encoded_key = xdr_client
    .encode_ledger_key(tonic::Request::new(ledger_key_encode_request))
    .await?;

// Get ledger entries using RPC client
let entries_request = stellar_rpc::GetLedgerEntriesParams {
    keys: vec![encoded_key.into_inner().encoded_value]
};

let ledger_entries = stellar_client
    .get_ledger_entries(tonic::Request::new(entries_request))
    .await?;
```

## How It Works: Behind the Scenes

The native SDK works through several key components:

### 1. Server Initialization

When `StartServer()` is called, the binary initializes a WebApplication with gRPC services (in `NativeGrpcServer.cs`):

```csharp
builder.Services.AddAotGrpcServices();
builder.Services.AddHttpClient("StellarClient");
builder.Services.AddSingleton<StellarRPCClient>();
builder.Services.AddSingleton<MuxedAccount_ProtoWrapper>();
builder.Services.AddSingleton<Transaction_ProtoWrapper>();
builder.Services.AddSingleton<Network_ProtoWrapper>();
builder.Services.AddSingleton<SimulateTransactionResult_ProtoWrapper>();
builder.Services.AddSingleton<XdrProtoService>();
```

It then configures platform-specific IPC:

```csharp
#if WINDOWS
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenNamedPipe("MyServicePipe", listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
    });
});
#else
// Linux/macOS: Unix domain sockets
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenUnixSocket("/tmp/MyService.sock", listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
    });
});
#endif
```

### 2. AOT Compilation and Trimming

The binary is compiled with AheadOfTime (AOT) compilation and aggressive trimming via `root.xml`:

```xml
<linker>
    <assembly fullname="StellarRPCSDK">
        <type fullname="StellarRPCSDK.*" preserve="all" />
    </assembly>
    
    <!-- Other trimming settings -->
</linker>
```

This ensures that only the necessary code is included, resulting in a compact binary.

### 3. Exposing Functionality

The SDK exposes functionality through gRPC service implementations that wrap the underlying .NET classes, translating between proto messages and .NET objects.

## Best Practices for Native Integration

1. **Error Handling**: Implement robust error handling around gRPC calls, as errors may occur at multiple levels (IPC, serialization, SDK logic).

2. **Resource Management**: Properly manage the lifecycle of the native binary, ensuring it's cleanly shut down when no longer needed.

3. **Thread Considerations**: The gRPC server runs on a background thread. Be aware of threading considerations in your application.

4. **Graceful Shutdown**: Use the provided `StopServer()` and `CleanupServer()` functions for graceful shutdown:

```rust
// Stop and clean up (pseudocode)
let stop_server: Symbol<unsafe extern "C" fn()> = unsafe { lib.get(b"StopServer")? };
let cleanup_server: Symbol<unsafe extern "C" fn()> = unsafe { lib.get(b"CleanupServer")? };
unsafe { stop_server() };
unsafe { cleanup_server() };
```

5. **Platform Paths**: Adjust paths to the native binary based on the target platform.

## Language-Specific Considerations

### C++ / Unreal Engine

For C++ applications including Unreal Engine:
- Use a C++ gRPC client library
- Consider wrapping the gRPC calls in a C++ abstraction layer
- For Unreal Engine, implement the integration in a native plugin

### Go

For Go applications:
- Use the standard `google.golang.org/grpc` package
- Generate Go code from the proto files using `protoc`
- Implement platform-specific IPC using Go's `net` package

### Python

For Python applications:
- Use the `grpcio` package
- Generate Python stubs with `grpcio-tools`
- Connect to the appropriate IPC mechanism using Python libraries

## Conclusion

The native bindings for the Stellar RPC SDK provide a powerful way to integrate Stellar network functionality into applications written in any programming language. By leveraging gRPC and platform-native IPC mechanisms, the SDK offers high-performance access to Stellar operations while maintaining the simplicity and reliability of the underlying .NET implementation.

With this approach, developers can build blockchain applications for platforms ranging from game engines to embedded systems, all using the same underlying SDK.