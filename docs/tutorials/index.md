# Stellar RPC SDK Tutorials

This section contains tutorials to help you understand and use the Stellar RPC SDK. Each tutorial focuses on specific functionality and provides step-by-step guidance with complete code examples.

## Basic Operations

### [Server Health Check](server-health.md)

Learn how to connect to the Stellar network and verify server health, protocol version, and network information. This is a good starting point for all applications.

**Key topics covered:**
- Setting up the Stellar RPC client
- Checking server health status
- Getting protocol version information
- Determining network details (testnet vs. mainnet)

### [Retrieving Account Information](account-info.md)

Learn how to retrieve and interpret Stellar account information, including balances, sequence numbers, and account flags.

**Key topics covered:**
- Converting account IDs to SDK objects
- Creating ledger keys for accounts
- Retrieving account entries
- Interpreting account data
- Working with account signers

## Transaction Operations

### [Creating and Sending Payment Transactions](payment-transaction.md)

Learn how to create, sign, and submit payment transactions to transfer XLM between accounts.

**Key topics covered:**
- Creating payment operations
- Building transactions
- Signing transactions with private keys
- Submitting transactions to the network
- Verifying transaction success and balance changes

### [Checking Transaction Status](transaction-status.md)

Learn how to check the status of submitted transactions and interpret transaction results.

**Key topics covered:**
- Retrieving transaction details by hash
- Polling for transaction status
- Understanding transaction results
- Extracting transaction metadata
- Error handling for failed transactions

## Soroban Smart Contracts

### [Invoking Soroban Contracts](soroban-invocation.md)

Learn how to interact with Soroban smart contracts by creating and submitting contract invocation transactions.

**Key topics covered:**
- Creating contract invocation operations
- Simulating transactions
- Applying simulation results
- Executing contract transactions
- Processing contract return values

### [Working with Nested Structures in Soroban](soroban-nested-structs.md)

Learn how to create and pass complex nested data structures to Soroban smart contracts.

**Key topics covered:**
- Creating nested SCMap structures
- Mapping Rust structs to Soroban contract data types
- Maintaining proper key ordering
- Processing nested structure return values
- Debugging structure-related issues

### [Soroban Authorizations](soroban-authorization.md)

Learn how to handle contract operations that require authorization from multiple accounts.

**Key topics covered:**
- Understanding Soroban authorization requirements
- Simulating transactions to determine needed authorizations
- Signing authorization payloads
- Adding multiple signatures to a transaction
- Processing contract operations with authorization

### [Monitoring Events](events-monitoring.md)

Learn how to monitor and filter events emitted by Soroban contracts and Stellar operations.

**Key topics covered:**
- Creating event filters
- Retrieving events by ledger range
- Processing event data
- Setting up pagination for event queries
- Real-time event monitoring strategies

## Advanced Topics

### [Working with Ledger Entries](ledger-entries.md)

Learn how to retrieve, interpret, and process various types of ledger entries beyond just accounts.

**Key topics covered:**
- Creating different types of ledger keys
- Retrieving multiple ledger entries
- Working with trustlines, offers, and data entries
- Understanding ledger entry TTL (Time To Live)
- Best practices for ledger entry caching

## More Tutorials Coming Soon

We're continuously working on new tutorials. Future topics will include:

- Creating and managing trustlines for custom assets
- Multi-signature transactions and operations
- Claimable balances
- Sponsored transactions
- Advanced Soroban contract interactions

Have a suggestion for a tutorial topic? [Let us know](https://github.com/yourusername/stellar-rpcsdk/issues)!
