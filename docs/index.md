# Stellar RPC SDK

A lightweight, cross-platform .NET and Native SDK for interacting with the Stellar network using the Stellar RPC API.

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

- [Installation Guide](getting-started/installation.md)
- [Quick Start Tutorial](getting-started/quickstart.md)
- [Setting Up Stellar Accounts](getting-started/accounts-setup.md)

## Use Case Tutorials

Learn how to use the SDK through practical examples:

- [Server Health Checks](tutorials/server-health.md)
- [Retrieving Account Information](tutorials/account-info.md)
- [Creating and Sending Payments](tutorials/payment-transaction.md)
- [Checking Transaction Status](tutorials/transaction-status.md)
- [Working with Ledger Entries](tutorials/ledger-entries.md)
- [Invoking Soroban Contracts](tutorials/soroban-invocation.md)
- [Soroban Authorizations](tutorials/soroban-authorizations.md)
- [Soroban Nested Structs](tutorials/soroban-nested-structs.md)
- [Monitoring Events](tutorials/events-monitoring.md)

## API Reference

- [StellarRPCClient](api/client.md)
- [Data Models](api/models.md)
- [Operations](api/operations.md)
- [Transactions](api/transactions.md)

## Platform-Specific Guides

- [Unity Integration](platforms/unity.md)
- [MAUI/Android Integration](platforms/maui.md)
- [Tizen Integration](platforms/tizen.md)
- [Native Bindings](platforms/native.md)

## License

This project is licensed under the [MIT License](LICENSE).

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.