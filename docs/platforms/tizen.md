# Stellar RPC SDK for Tizen

This guide explains how to use the Stellar RPC SDK in Tizen applications, particularly for Smart TV applications. The Stellar_Tizen demo project serves as a reference implementation.

## Overview

Tizen is Samsung's open-source operating system that powers Smart TVs, wearables, and other IoT devices. The Stellar RPC SDK can be integrated with Tizen applications to enable blockchain functionality on these devices.

## Prerequisites

- Tizen Studio with appropriate SDK extensions
- Visual Studio with Tizen extension (for .NET development)
- Basic understanding of Tizen application development
- Basic understanding of the Stellar blockchain

## Installation

To use the Stellar RPC SDK in your Tizen project, you need to add the specific Tizen-compatible NuGet package:

```xml
<ItemGroup>
  <PackageReference Include="StellarRPCSDK.Tizen" Version="1.0.0" />
</ItemGroup>
```

This special package is optimized for Tizen's environment and includes necessary adaptations for the platform.

## Key Considerations for Tizen

### Target Framework

The demo application targets Tizen 5.0, which is important for compatibility with the majority of deployed devices:

```xml
<PropertyGroup>
  <OutputType>Exe</OutputType>
  <TargetFramework>tizen50</TargetFramework>
</PropertyGroup>
```

While newer versions of Tizen exist, many Smart TVs and wearable devices in the wild are running Tizen 5.0 or earlier. This ensures broader compatibility rather than targeting only the newest devices.

### Assembly Resolution

A critical aspect of the Tizen integration is proper assembly resolution. The demo project uses a custom assembly resolver to ensure that all needed libraries are correctly loaded:

```csharp
AppDomain.CurrentDomain.AssemblyResolve += (object s, ResolveEventArgs eventArgs) =>
{
    var appDir = Path.GetDirectoryName(typeof(Program).Assembly.Location);
    var fullName = eventArgs.Name;
    var reqName = eventArgs.RequestingAssembly.FullName;
    var assemblyName = eventArgs.Name.Split(',')[0];
    var assemblyPath = Path.Combine(appDir, assemblyName + ".dll");
    bool exists = File.Exists(assemblyPath);
    if (exists) return Assembly.LoadFile(assemblyPath); else return null;
};
```

This resolver is necessary because Tizen's .NET runtime sometimes has difficulty finding assemblies, especially third-party dependencies. The resolver looks for assemblies in the application directory, which helps ensure that all dependencies are properly loaded at runtime.

### SSL Certificate Validation

When working with local SSL endpoints or during development, you might need to disable certificate validation:

```csharp
#if DEBUG
DisableCertificateValidation();
#endif

private void DisableCertificateValidation()
{
    // USE if working with local SSL RPC
    ServicePointManager.ServerCertificateValidationCallback +=
        (sender, cert, chain, sslPolicyErrors) => true;
}
```

This should only be used during development and testing, never in production applications.

## Project Structure

The Stellar_Tizen demo application follows a typical Xamarin.Forms project structure adapted for Tizen:

### Stellar_Tizen (Core Project)
This contains the shared, platform-independent code:
- **Models**: Contains data models and interfaces like `IStellarService` 
- **ViewModels**: Implements MVVM pattern viewmodels
- **Views**: Contains Xamarin.Forms UI definitions
- **Converters**: Helper classes for UI data binding

### Stellar_Tizen.Tizen (Tizen Platform Project)
This contains the Tizen-specific implementation:
- **Program.cs**: Main entry point and application initialization
- **Services**: Platform-specific implementations of interfaces (like `StellarService`)
- **SecureStorage**: Implementation of secure storage for Tizen using the `SecureRepository` API

## Secure Storage Implementation

The demo leverages Tizen's SecureRepository for safely storing sensitive data like Stellar private keys:

```csharp
public class Data : Secure<byte[]>
{
    // Methods for securely storing and retrieving data
}
```

This is particularly important for blockchain applications where secure storage of private keys is essential.

## UI Considerations

The demo application uses a simplified UI approach suitable for TV navigation:

- Larger font sizes and UI elements for readable display on TVs
- Simple navigation model considering remote control interaction
- QR code generation for displaying Stellar addresses

## Xamarin.Forms vs MAUI

The demo uses Xamarin.Forms rather than .NET MAUI because:

1. Better compatibility with Tizen 5.0 devices
2. More established support for Tizen TVs
3. Wider deployment base in existing Samsung devices

While MAUI is the future direction for cross-platform .NET development, Xamarin.Forms currently offers more stable support for Tizen TV applications.

## Example: Using the StellarService

The demo implements a `StellarService` that provides core Stellar functionality:

```csharp
public class StellarService : IStellarService
{
    private const string StellarKeyAlias = "STELLAR_SK";
    private Data _data;
    private HttpClient _httpClient;
    private StellarRPCClient _sorobanClient;

    // Methods for interacting with Stellar accounts and the network
}
```

This service demonstrates:
1. Secure storage and retrieval of Stellar keys
2. Setting up and configuring the StellarRPCClient
3. Getting account information and balances
4. Handling HTTP timeouts appropriately for TV applications

## Best Practices for Tizen Integration

1. **Timeout Handling**: Set generous timeouts for network operations, as TV network connections may be slower or less stable than mobile devices:
   ```csharp
   _httpClient.Timeout = TimeSpan.FromSeconds(3000);
   ```

2. **Error Handling**: Implement comprehensive error handling, especially for network operations, to provide graceful degradation when connectivity issues occur.

3. **UI Thread**: Be careful about operations on the UI thread, as Tizen devices may have limited processing power:
   ```csharp
   Device.BeginInvokeOnMainThread(async () => {
       // UI updates here
   });
   ```

4. **Resource Management**: Be mindful of memory and resource usage, as TVs often have more constrained environments than other devices.

5. **Testing**: Test on actual Tizen devices rather than just emulators, as there can be significant differences in behavior.

## Privileges

The demo application requests several privileges in its manifest:

```xml
<privileges>
    <privilege>http://tizen.org/privilege/externalstorage</privilege>
    <privilege>http://tizen.org/privilege/mediastorage</privilege>
    <privilege>http://tizen.org/privilege/content.write</privilege>
    <privilege>http://tizen.org/privilege/internet</privilege>
</privileges>
```

Make sure to request the appropriate privileges for your application, especially `internet` for network access and appropriate storage privileges for persisting data.

## Troubleshooting

### Common Issues

1. **Assembly Loading Failures**: If you encounter assembly loading issues, verify that all dependencies are correctly included in the project and that the assembly resolver is properly implemented.

2. **Network Connection Issues**: Tizen TVs may have more network constraints. Implement proper retry logic and timeout handling.

3. **UI Rendering Issues**: Test UI layouts on actual TV devices to ensure proper rendering and navigation with remote controls.

### Debug Output

Use Tizen's logging mechanism for debugging:

```csharp
global::Tizen.Log.Error("SecureRepository_DATA", ex.Message);
```

## Conclusion

The Stellar RPC SDK can be effectively integrated with Tizen applications, enabling blockchain functionality on Samsung Smart TVs and other Tizen devices. By following the patterns in the demo application and considering the specific requirements of the Tizen platform, you can build robust Stellar-enabled applications for this ecosystem.

Remember to target Tizen 5.0 for maximum compatibility with deployed devices, implement proper assembly resolution, and follow secure practices for handling sensitive blockchain data.