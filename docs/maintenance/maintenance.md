# Stellar SDK Build and Release Guide

This document outlines the **manual** process for updating the Stellar SDK from updated OpenRPC and XDR specifications, building all variants, and creating releases.
The GitHub Action that makes this semiautomatic can be found [here](../tutorials/payment-transaction.md)

## Overview

The build process consists of several stages:
1. Fetching the latest OpenRPC and XDR definitions
2. Generating code artifacts using the Generator tool
3. Building the SDK for different platforms (.NET Standard, Unity, Tizen)
4. Generating protocol buffer wrappers for NativeAOT
5. Building and publishing NativeAOT binaries
6. Creating and publishing NuGet packages

## Prerequisites

- .NET 8.0 SDK
- Git
- NuGet CLI or .NET CLI for package management
- Access to GitHub repositories and releases

## 1. Fetch Latest Definitions

First, clone or update the repositories containing the latest OpenRPC and XDR definitions:

```bash
# Create folders for sources if they don't exist
mkdir -p StellarOpenRPC
mkdir -p StellarXDR

# Fetch the latest OpenRPC definition
curl -L https://raw.githubusercontent.com/stellar/stellar-rpc/main/docs/specs/stellar-rpc.openrpc.json -o StellarOpenRPC/stellar-rpc.openrpc.json

# Fetch XDR definitions from stellar-core
git clone https://github.com/stellar/stellar-core.git temp-stellar-core
cp temp-stellar-core/src/protocol-curr/*.x StellarXDR/
rm -rf temp-stellar-core
```

## 2. Run Code Generation

Use the Generator tool to create the SDK code files from the specifications:

```bash
# Define paths
ROOT_DIR=$(pwd)
XDR_SOURCE_DIR="$ROOT_DIR/StellarXDR"
OPENRPC_SOURCE="$ROOT_DIR/StellarOpenRPC/stellar-rpc.openrpc.json"
XDR_OUTPUT_DIR="$ROOT_DIR/StellarRPCSDK/Stellar/Generated"
RPC_OUTPUT_DIR="$ROOT_DIR/StellarRPCSDK/RPC/Generated"

# Run the generator
dotnet run --project Generator/Generator.csproj -- "$XDR_SOURCE_DIR" "$OPENRPC_SOURCE" "$XDR_OUTPUT_DIR" "$RPC_OUTPUT_DIR"
```

## 3. Build Standard SDK Variants

Build the SDK for the different platforms:

```bash
# Build .NET Standard 2.0 (default) version
dotnet build StellarRPCSDK/StellarRPCSDK.csproj -c Release

# Build Unity version
dotnet build StellarRPCSDK/StellarRPCSDK.csproj -c Unity

# Build Tizen version
dotnet build StellarRPCSDK/StellarRPCSDK.csproj -c Tizen
```

> **⚠️ IMPORTANT**: After generation and initial build, manually review the output for errors. OpenRPC or XDR specifications may contain issues requiring manual workarounds. If you encounter errors, fix them in the generated code or adjust the Generator tool for special cases, then rebuild.

## 4. Generate Protocol Buffer Wrappers for NativeAOT

Generate the gRPC/protobuf wrappers for the native AOT version:

```bash
# Build SDK in NativeAOT configuration first
dotnet build StellarRPCSDK/StellarRPCSDK.csproj -c NativeAOT

# Define output directory for gRPC artifacts
GRPC_OUTPUT_DIR="$ROOT_DIR/StellarRPCSDK_Native/gRPC"
mkdir -p "$GRPC_OUTPUT_DIR"

# Run the proto generator
dotnet run --project ProtoGenerator/ProtoGenerator.csproj -- --proto "$ROOT_DIR/StellarRPCSDK_Native" --grpc-aot "$GRPC_OUTPUT_DIR"
```

## 5. Build and Publish NativeAOT Binaries

Build and publish the native binaries for different platforms:

```bash
# Define the platforms to build for
PLATFORMS=("win-x64" "win-arm64" "linux-x64" "linux-arm64" "osx-x64" "osx-arm64")

# Create output directory for binaries
mkdir -p "$ROOT_DIR/Releases/Binaries"

# Build and publish for each platform
for platform in "${PLATFORMS[@]}"; do
    echo "Building for platform: $platform"
    dotnet publish StellarRPCSDK_Native/StellarRPCSDK_Native.csproj \
        -c Release \
        -r $platform \
        --self-contained \
        -o "$ROOT_DIR/Releases/Binaries/$platform"
done
```

## 6. Create NuGet Packages

Create NuGet packages for the SDK:

```bash
# Set version (can be configured as an input parameter)
VERSION="1.0.0"

# Create NuGet packages
dotnet pack StellarRPCSDK/StellarRPCSDK.csproj -c Release -p:PackageVersion=$VERSION -o "$ROOT_DIR/Releases/NuGet"
dotnet pack StellarRPCSDK/StellarRPCSDK.csproj -c Unity -p:PackageVersion=$VERSION -o "$ROOT_DIR/Releases/NuGet"
dotnet pack StellarRPCSDK/StellarRPCSDK.csproj -c Tizen -p:PackageVersion=$VERSION -o "$ROOT_DIR/Releases/NuGet"
```

## Version Management

To manage versioning properly, update your `.csproj` file to include version properties:

```xml
<PropertyGroup>
  <Version>1.0.0</Version>
  <AssemblyVersion>1.0.0.0</AssemblyVersion>
  <FileVersion>1.0.0.0</FileVersion>
  <PackageVersion>1.0.0</PackageVersion>
</PropertyGroup>
```

For automated builds, you can set these values through the command line:

```bash
dotnet build -p:Version=1.2.3 -p:AssemblyVersion=1.2.3.0 -p:FileVersion=1.2.3.0 -p:PackageVersion=1.2.3
```

## Handling SDK Updates and Specification Changes

When OpenRPC or XDR specifications change, the following workflow is recommended:

1. Fetch the latest specs
2. Run the generator
3. Build and test all SDK variants
4. If errors occur:
   - Analyze if they're due to inconsistencies in the specifications
   - Update the Generator tool to handle special cases
   - Apply manual fixes to generated code if necessary
   - Document these changes for future reference
5. Continue with building NativeAOT and publishing releases

## Common Issues and Solutions

### OpenRPC Specification Issues

1. **Missing or incorrect property types**: Occasionally, the OpenRPC spec may define properties with incompatible types. Check the Generator output for errors and modify the types in the generated C# code to match the actual data structure.

2. **Enum value discrepancies**: Some enum values in the OpenRPC spec might not match those in the XDR definitions. You may need to add missing values or correct existing ones.

3. **Inconsistent naming**: Property names in the OpenRPC spec might not follow C# naming conventions. The generator attempts to convert these, but manual adjustments may be needed.

### XDR Definition Issues

1. **Nested type visibility**: Nested types in XDR definitions might require adjustments to their visibility modifiers in the generated C# code.

2. **Union type handling**: XDR unions can sometimes generate code that's difficult to use in C#. You may need to add helper methods or properties to simplify usage.

### NativeAOT-specific Issues

1. **Trimming warnings**: NativeAOT trimming might remove necessary code. Add trimming roots or annotations to preserve required types and methods.

2. **Serialization compatibility**: Ensure that serialization attributes are compatible with NativeAOT's requirements.

## Manual Steps and Considerations

Despite the automation, some steps require manual intervention:

1. **Specification issues**: When the OpenRPC or XDR specs have inconsistencies, you might need to manually fix generated code.

2. **Testing**: Always manually test the generated SDK with real-world Stellar network interactions.

3. **Documentation**: Update documentation to reflect any API changes.

4. **Version bumping**: Decide on the version increment following semantic versioning practices.

## Updating the SDK

Here's a checklist for SDK updates:

1. Check for updates to OpenRPC and XDR definitions
2. Run the Generator tool
3. Review the generated code for issues
4. Fix any errors from specification inconsistencies
5. Build all variants
6. Run tests against the live Stellar network
7. Update documentation if API changes occurred
8. Increment version according to semantic versioning
9. Build and publish releases

## Making a New Release

1. Determine the new version number based on semantic versioning:
   - **Major version**: Breaking changes
   - **Minor version**: New features, non-breaking changes
   - **Patch version**: Bug fixes and minor improvements

2. Update version numbers in project files or pass them as parameters during build

3. Commit your changes with a detailed message describing the update

4. Tag the commit with the version number (e.g., `v1.2.3`)

5. Push the changes and tag to GitHub

6. Create a new GitHub release based on the tag
   - Include a detailed changelog
   - Attach built NuGet packages and native binaries

7. Publish NuGet packages to NuGet.org