# Stellar RPC SDK

A lightweight, cross-platform .NET and Native SDK for interacting with the Stellar network using the Stellar RPC API.

This project was funded by the Stellar Community Fund. The original project proposal can now be [found here](docs/original_project_plan.md)

## Overview

The Stellar RPC SDK provides a clean, type-safe way to interact with the Stellar network from any .NET application, and from native applications on any other platform. It supports all Soroban RPC operations and provides convenient abstractions for common Stellar operations.

Key features include:

- **Complete Soroban RPC Support**: Supports all endpoints in the Soroban RPC API
- **XDR Serialization**: Full XDR encoding and decoding for all Stellar data types
- **Type Safety**: Strong C# typing for Stellar operations and responses
- **Cross-Platform**: Works on .NET Core, Unity, MAUI, Tizen and more
- **Async First**: Fully asynchronous API for responsive applications
- **Comprehensive XDR Support**: All Stellar XDR types are available
- **Automatic Updates**: The RPC, XDR and Protobuf (for native) types are automatically generated based on Stellar specifications

## Getting Started

- [Installation Guide](docs/getting-started/installation.md)
- [Quick Start Tutorial](docs/getting-started/quickstart.md)
- [Setting Up Stellar Accounts](docs/getting-started/accounts-setup.md)

## Use Case Tutorials

Learn how to use the SDK through practical examples:

- [Server Health Checks](docs/tutorials/server-health.md)
- [Retrieving Account Information](docs/tutorials/account-info.md)
- [Creating and Sending Payments](docs/tutorials/payment-transaction.md)
- [Checking Transaction Status](docs/tutorials/transaction-status.md)
- [Working with Ledger Entries](docs/tutorials/ledger-entries.md)
- [Invoking Soroban Contracts](docs/tutorials/soroban-invocation.md)
- [Soroban Authorizations](docs/tutorials/soroban-authorizations.md)
- [Soroban Nested Structs](docs/tutorials/soroban-nested-structs.md)

## API Reference

- [StellarRPCClient](docs/api/client.md)
- [Data Models](docs/api/models.md)

## Platform-Specific Guides

- [Unity Integration](docs/platforms/unity.md)
- [MAUI/Android Integration](docs/platforms/maui.md)
- [Tizen Integration](docs/platforms/tizen.md)
- [Native Bindings](docs/platforms/native.md)

## SDK Maintenance

- [Maintenance Guide](docs/maintenance/maintenance.md)

## License

This project is licensed under the [MIT License](LICENSE).

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.