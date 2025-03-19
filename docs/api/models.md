# Stellar RPC SDK Models

## Table of Contents

- [Stellar RPC SDK Models](#stellar-rpc-sdk-models)
  - [RPC Models](#rpc-models)
    - [Request Parameter Models](#request-parameter-models)
      - [GetLedgerEntriesParams](#getledgerentriesparams)
      - [GetTransactionParams](#gettransactionparams)
      - [GetTransactionsParams](#gettransactionsparams)
      - [SendTransactionParams](#sendtransactionparams)
      - [SimulateTransactionParams](#simulatetransactionparams)
      - [GetEventsParams](#geteventsparams)
    - [Response Models](#response-models)
      - [GetHealthResult](#gethealthresult)
      - [GetNetworkResult](#getnetworkresult)
      - [GetVersionInfoResult](#getversioninforesult)
      - [GetLatestLedgerResult](#getlatestledgerresult)
      - [GetLedgerEntriesResult](#getledgerentriesresult)
      - [GetTransactionResult](#gettransactionresult)
      - [GetTransactionsResult](#gettransactionsresult)
      - [SendTransactionResult](#sendtransactionresult)
      - [SimulateTransactionResult](#simulatetransactionresult)
      - [GetEventsResult](#geteventsresult)
      - [GetFeeStatsResult](#getfeestatsresult)
  - [Stellar Models](#stellar-models)
    - [MuxedAccount](#muxedaccount)
      - [KeyTypeEd25519](#keytypeed25519)
      - [KeyTypeMuxedEd25519](#keytypemuxeded25519)
      - [Static MuxedAccount Factory Methods](#static-muxedaccount-factory-methods)
    - [Transaction](#transaction)
    - [FeeBumpTransaction](#feebumptransaction)
    - [Network](#network)
    - [SequenceNumber](#sequencenumber)
  - [XDR Utility Classes](#xdr-utility-classes)
    - [XdrWriter](#xdrwriter)
    - [XdrReader](#xdrreader)
  - [JSON-RPC Support Classes](#json-rpc-support-classes)
    - [JsonRpcRequest](#jsonrpcrequest)
    - [JsonRpcResponse<T>](#jsonrpcresponset)
    - [JsonRpcError](#jsonrpcerror)
    - [JsonRpcException](#jsonrpcexception)

This document provides an overview of the key model classes in the Stellar RPC SDK. The SDK contains two primary categories of models:

1. **RPC Models**: Classes related to the Soroban RPC API requests and responses
2. **Stellar Models**: Core Stellar data structures used in transactions and ledger entries

## RPC Models

The RPC models represent request parameters and response objects for the Soroban RPC API. These are primarily found in the `Stellar.RPC` namespace.

### Request Parameter Models

These models are used to construct requests to the Stellar RPC API.

#### GetLedgerEntriesParams

This class is used for retrieving specific ledger entries by their keys.

**Properties:**
- **Keys**: A collection of base64-encoded ledger keys that you want to retrieve. The API imposes a limit of 200 keys per request.

#### GetTransactionParams

This class is used to retrieve information about a specific transaction.

**Properties:**
- **Hash**: A 64-character hexadecimal string representing the transaction hash you want to look up.

#### GetTransactionsParams

This class allows you to retrieve multiple transactions within a specific ledger range.

**Properties:**
- **StartLedger**: The sequence number of the starting ledger from which to retrieve transactions.
- **Pagination**: Optional pagination parameters to limit the number of results and continue from a previous query.

#### SendTransactionParams

This class is used to submit a transaction to the Stellar network.

**Properties:**
- **Transaction**: A base64-encoded string representing the XDR-serialized transaction envelope.

#### SimulateTransactionParams

This class allows you to simulate a transaction without submitting it to the network.

**Properties:**
- **Transaction**: A base64-encoded string representing the XDR-serialized transaction envelope.
- **ResourceConfig**: Optional configuration for how resources will be calculated during simulation.

#### GetEventsParams

This class enables you to request filtered events from a range of ledgers.

**Properties:**
- **StartLedger**: The sequence number of the starting ledger from which to retrieve events.
- **Filters**: A collection of filter criteria to narrow down the events returned (limited to 5 filters).
- **Pagination**: Optional pagination parameters for handling large result sets.

### Response Models

These models represent responses from the Stellar RPC API.

#### GetHealthResult

Contains information about the health status of the Stellar RPC server.

**Properties:**
- **Status**: The server status, typically "healthy" if operating normally.
- **LatestLedger**: The sequence number of the most recent ledger known to the server.
- **OldestLedger**: The sequence number of the oldest ledger kept in the server's history.
- **LedgerRetentionWindow**: The maximum number of ledgers that the server is configured to retain.

#### GetNetworkResult

Provides information about the Stellar network that the RPC server is connected to.

**Properties:**
- **Passphrase**: The network passphrase that identifies the Stellar network (e.g., "Test SDF Network ; September 2015").
- **ProtocolVersion**: The Stellar Core protocol version associated with the latest ledger.
- **FriendbotUrl**: Optional URL for a "friendbot" faucet service that can fund test accounts.

#### GetVersionInfoResult

Contains version information about the RPC server and its components.

**Properties:**
- **Version**: The version of the RPC server.
- **Commit_hash**: The Git commit hash of the RPC server codebase.
- **Build_time_stamp**: The timestamp when the RPC server was built.
- **Captive_core_version**: The version of the Captive Core instance used by the server.
- **Protocol_version**: The Stellar protocol version supported by the server.

#### GetLatestLedgerResult

Provides information about the latest ledger in the Stellar network.

**Properties:**
- **Id**: The hash identifier of the latest ledger, as a 64-character hexadecimal string.
- **ProtocolVersion**: The Stellar Core protocol version associated with this ledger.
- **Sequence**: The sequence number of the latest ledger.

#### GetLedgerEntriesResult

Contains the results of querying specific ledger entries.

**Properties:**
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.
- **Entries**: A collection of ledger entries that match the requested keys.

**Extended Functionality:**
- **LedgerKey**: A property added to the `Entries` class that provides the deserialized ledger key object, making it easier to work with the key without manually deserializing it.
- **LedgerEntryData**: A property added to the `Entries` class that provides the deserialized ledger entry data, allowing direct access to the entry's contents.

#### GetTransactionResult

Contains detailed information about a specific transaction.

**Properties:**
- **Status**: The current status of the transaction (SUCCESS, FAILED, or NOT_FOUND).
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.
- **LatestLedgerCloseTime**: The timestamp when the latest ledger was closed.
- **OldestLedger**: The sequence number of the oldest ledger available in the server's history.
- **OldestLedgerCloseTime**: The timestamp when the oldest available ledger was closed.
- **Ledger**: The sequence number of the ledger that includes this transaction (only present for SUCCESS or FAILED).
- **CreatedAt**: The timestamp when the transaction was included in the ledger (only present for SUCCESS or FAILED).
- **ApplicationOrder**: The index of the transaction within the ledger (only present for SUCCESS or FAILED).
- **FeeBump**: Indicates whether the transaction was a fee bump transaction (only present for SUCCESS or FAILED).
- **EnvelopeXdr**: Base64-encoded XDR of the transaction envelope.
- **ResultXdr**: Base64-encoded XDR of the transaction result (only present for SUCCESS or FAILED).
- **ResultMetaXdr**: Base64-encoded XDR of the transaction metadata.

**Extended Functionality:**
- **TransactionResult**: A property that provides the deserialized transaction result object, allowing you to work with the result data directly.
- **TransactionResultMeta**: A property that provides the deserialized transaction metadata object, containing detailed information about the transaction's effects.
- **TransactionEnvelope**: A property that provides the deserialized transaction envelope object, allowing direct access to the transaction contents.

#### GetTransactionsResult

Contains a list of transactions matching the query criteria.

**Properties:**
- **Transactions**: A collection of transaction objects matching the query.
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.
- **LatestLedgerCloseTimestamp**: The timestamp when the latest ledger was closed.
- **OldestLedger**: The sequence number of the oldest ledger available in the server's history.
- **OldestLedgerCloseTimestamp**: The timestamp when the oldest available ledger was closed.

**Extended Functionality:**
- **TransactionResult**: A property added to the `Transactions` class that provides the deserialized transaction result.
- **TransactionResultMeta**: A property added to the `Transactions` class that provides the deserialized transaction metadata.
- **TransactionEnvelope**: A property added to the `Transactions` class that provides the deserialized transaction envelope.
- **DiagnosticEvents**: A property added to the `Transactions` class that provides deserialized diagnostic events, if available.

#### SendTransactionResult

Contains the result of submitting a transaction to the network.

**Properties:**
- **Hash**: The transaction hash as a 64-character hexadecimal string.
- **Status**: The status of the submission (PENDING, DUPLICATE, TRY_AGAIN_LATER, or ERROR).
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.
- **LatestLedgerCloseTime**: The timestamp when the latest ledger was closed.
- **ErrorResultXdr**: Base64-encoded XDR of the error result, if the status is ERROR.
- **DiagnosticEventsXdr**: Base64-encoded XDR of any diagnostic events, if the status is ERROR.

**Extended Functionality:**
- **ErrorResult**: A property that provides the deserialized error result, making it easier to understand what went wrong.
- **DiagnosticEvents**: A property that provides the deserialized diagnostic events, offering further insights into the error.

#### SimulateTransactionResult

Contains the result of simulating a transaction without actually submitting it to the network.

**Properties:**
- **LatestLedger**: The sequence number of the latest ledger at the time of the simulation.
- **MinResourceFee**: The recommended minimum resource fee to add when submitting the transaction.
- **Cost**: Resource consumption information (CPU instructions and memory).
- **Results**: Results from any Host Function invocations in the transaction.
- **TransactionData**: Base64-encoded serialized Soroban Transaction Data containing resource usage information.
- **Events**: Base64-encoded events emitted during the simulation.
- **RestorePreamble**: Information needed to restore archived ledger entries, if applicable.
- **StateChanges**: Changes to the ledger state caused by the transaction.
- **Error**: Error information if the simulation failed.

**Extended Functionality:**
- **SorobanTransactionData**: A property that provides the deserialized Soroban Transaction Data.
- **DiagnosticEvents**: A property that provides the deserialized diagnostic events.
- **GetAuthorisationsRequired**: A method that extracts required authorizations from the simulation result, with an optional parameter to specify the ledger expiration. This is useful for transactions that require signatures from multiple accounts.
- **AddAuthorisationSignature**: A method to add an authorization signature to the simulation result, used when building transactions that require multiple signatures.
- **ApplyTo**: A method that applies the simulation results to a transaction, preparing it for submission to the network. This is a critical utility method for the Soroban contract invocation workflow.

The `Results` class within SimulateTransactionResult has these extended properties:
- **Result**: A property that provides the deserialized return value from a contract invocation.
- **SorobanAuthorizations**: A property that provides the deserialized Soroban authorizations required by the contract.

The `RestorePreamble` class has this extended property:
- **SorobanTransactionData**: A property that provides the deserialized Soroban Transaction Data needed for footprint restoration.

The `StateChanges` class has these extended properties:
- **LedgerBefore**: A property that provides the deserialized ledger entry before the change.
- **LedgerAfter**: A property that provides the deserialized ledger entry after the change.

#### GetEventsResult

Contains events matching the specified filters.

**Properties:**
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.
- **Events**: A collection of events matching the filter criteria.

#### GetFeeStatsResult

Contains statistics about transaction fees on the network.

**Properties:**
- **SorobanInclusionFee**: Fee statistics for Soroban transactions.
- **InclusionFee**: Fee statistics for regular Stellar transactions.
- **LatestLedger**: The sequence number of the latest ledger at the time of the request.

## Stellar Models

The Stellar models represent core data structures for Stellar transactions and ledger entries. These classes are primarily found in the `Stellar` namespace.

### MuxedAccount

Represents a Stellar account, potentially with an additional multiplexed ID. This class is the cornerstone of Stellar authentication as it manages the keypairs used for signing transactions.

**Properties:**
- **PublicKey**: The account's public key as a byte array, used for identification and signature verification.
- **PrivateKey**: The account's private key as a byte array, used for signing transactions (only available if created with a secret seed).
- **SeedBytes**: The raw seed bytes from which the keypair was generated (only available if created with a secret seed).
- **SecretSeed**: The secret seed in StrKey encoding (only available if created with a secret seed).
- **XdrPublicKey**: The public key formatted as an XDR PublicKey object for use in Stellar XDR structures.
- **XdrSignerKey**: The public key formatted as an XDR SignerKey object for use in signer configurations.
- **AccountId**: The account ID in StrKey encoding (G... address), used widely in Stellar APIs and tools.
- **Address**: The full account address in encoded form (includes multiplexed information for KeyTypeMuxedEd25519).

**Methods:**
- **CanSign**: Checks if this account has the private key necessary to sign transactions. Use this before attempting to sign operations to avoid errors.
- **Sign**: Signs a data payload with this account's private key. Used when creating signatures for transactions.
- **SignDecorated**: Signs a data payload and returns a DecoratedSignature object ready for inclusion in a transaction envelope.
- **Verify**: Verifies that a signature was created by this account's private key. Useful for signature validation.

#### KeyTypeEd25519

A subclass of MuxedAccount that represents a standard Ed25519 account.

**Properties:**
- All properties inherited from MuxedAccount.
- The address format is the standard Stellar account ID (G...).

#### KeyTypeMuxedEd25519

A subclass of MuxedAccount that represents a multiplexed Ed25519 account, which includes an additional identifier for payment destinations.

**Properties:**
- All properties inherited from MuxedAccount.
- The address format includes both the account ID and the multiplexed ID (M...).

#### Static MuxedAccount Factory Methods

The MuxedAccount class provides several static factory methods for creating account instances:

- **FromSecretSeed(string)**: Creates an account from a StrKey-encoded secret seed. Use this when you have a Stellar secret key in string format.
- **FromSecretSeed(byte[])**: Creates an account from raw seed bytes. Used when you have direct access to the binary seed data.
- **FromAccountId(string)**: Creates an account from a StrKey-encoded account ID. This account can only verify signatures but cannot sign, as it has no private key.
- **FromBIP39Seed(string, uint)**: Creates an account from a BIP39 mnemonic seed string and account index. Useful for working with hardware wallets or BIP39 recovery phrases.
- **FromBIP39Seed(byte[], uint)**: Creates an account from BIP39 seed bytes and account index. Alternative to the string version when you have the raw seed data.
- **FromPublicKey(byte[])**: Creates an account from a raw public key. This account can only verify signatures but cannot sign.
- **Random()**: Generates a new random account. Useful for testing or creating new accounts.

### Transaction

Represents a Stellar transaction containing operations to be executed on the network.

**Methods:**
- **Clone**: Creates a deep copy of this transaction. Useful when you need to modify a transaction without affecting the original.
- **IsSoroban**: Checks if this is a Soroban transaction (contains Soroban-specific operations). Use this to determine if special Soroban processing is needed.
- **IsSorobanInvocation**: Checks if this is specifically a Soroban contract invocation. More specific than IsSoroban for direct contract calls.
- **Sign**: Signs the transaction using an account and the current Network. This creates a signature that can be added to the transaction envelope.

### FeeBumpTransaction

Represents a fee bump transaction, which allows one account to pay the fee for another account's transaction.

**Methods:**
- **Sign**: Signs the fee bump transaction using an account and the current Network. Used to authorize the fee payment.

### Network

Represents a Stellar network configuration, distinguishing between different Stellar networks such as public, testnet, or custom networks.

**Properties:**
- **NetworkPassphrase**: The passphrase that identifies the specific Stellar network.
- **NetworkId**: The computed network ID hash derived from the passphrase.
- **Url**: The URL of the network's RPC server (static property).
- **Current**: The currently active network configuration (static property).

**Methods:**
- **Public()**: Creates a Network instance for the public Stellar network. Use this to connect to the main Stellar network.
- **Test()**: Creates a Network instance for the Stellar testnet. Use this for development and testing.
- **Use(Network)**: Sets the current network to the specified instance. Call this before creating or signing transactions.
- **IsPublicNetwork(Network)**: Checks if a network is the public Stellar network. Useful for conditional logic based on network type.
- **UsePublicNetwork()**: Sets the current network to the public network. Convenience method for Use(Public()).
- **UseTestNetwork()**: Sets the current network to the test network. Convenience method for Use(Test()).
- **SetUrl(string)**: Sets the network URL for RPC connections. Call this to specify a custom server URL.

### SequenceNumber

Represents a sequence number for a Stellar transaction, which prevents transaction replay and ensures order.

**Methods:**
- **Increment()**: Increments this sequence number and returns it. Useful when creating a series of transactions from the same account.

## XDR Utility Classes

The SDK includes utility classes for working with XDR (External Data Representation) encoding and decoding.

### XdrWriter

A utility class for writing XDR-encoded data to a stream.

**Methods:**
- **WriteInt, WriteUInt, WriteLong, WriteULong, WriteFloat, WriteDouble**: Methods for writing primitive data types.
- **WriteOpaque**: Writes variable-length opaque data with a length prefix.
- **WriteFixedOpaque**: Writes fixed-length opaque data without a length prefix.
- **WriteString**: Writes a string in XDR format.
- **Flush**: Flushes any buffered data to the underlying stream.

### XdrReader

A utility class for reading XDR-encoded data from a stream.

**Methods:**
- **ReadInt, ReadUInt, ReadLong, ReadULong, ReadFloat, ReadDouble**: Methods for reading primitive data types.
- **ReadOpaque**: Reads variable-length opaque data with a length prefix.
- **ReadFixedOpaque**: Reads fixed-length opaque data into a pre-allocated buffer.
- **ReadString**: Reads a string in XDR format.
- **Skip**: Skips a specified number of bytes in the stream.

## JSON-RPC Support Classes

These classes provide support for the JSON-RPC communication protocol used by the Stellar RPC API.

### JsonRpcRequest

Represents a JSON-RPC request to the Stellar RPC server.

**Properties:**
- **JsonRpc**: The JSON-RPC version, always set to "2.0".
- **Method**: The name of the RPC method to call.
- **Params**: The parameters for the RPC method call.
- **Id**: A request identifier used to match responses to requests.

### JsonRpcResponse<T>

Represents a JSON-RPC response from the Stellar RPC server.

**Properties:**
- **JsonRpc**: The JSON-RPC version.
- **Result**: The result of the RPC method call, of type T.
- **Error**: Error information if the call failed.
- **Id**: The request identifier from the original request.

### JsonRpcError

Represents an error in a JSON-RPC response.

**Properties:**
- **Code**: The error code.
- **Message**: A human-readable error message.
- **Data**: Additional error data, if available.

### JsonRpcException

An exception thrown when a JSON-RPC error occurs.

**Properties:**
- **Code**: The error code from the JSON-RPC error.
- **ErrorData**: Additional error data from the JSON-RPC error.