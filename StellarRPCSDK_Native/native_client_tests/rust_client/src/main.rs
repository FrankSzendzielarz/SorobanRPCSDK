use libloading::{Library, Symbol};
use tonic::transport::{Channel, Uri};
use tower::service_fn;
use tokio::net::windows::named_pipe::ClientOptions;
use crate::stellar_rpc::stellar_client::StellarClient;
use crate::stellar::{
    xdr_proto_service_client::XdrProtoServiceClient,
    muxed_account_proto_wrapper_client::MuxedAccountProtoWrapperClient,
    network_proto_wrapper_client::NetworkProtoWrapperClient,
    transaction_proto_wrapper_client::TransactionProtoWrapperClient,
};


// Import the generated code
pub mod stellar_rpc {
    tonic::include_proto!("stellar.rpc");
}

pub mod stellar {
    tonic::include_proto!("stellar");
}

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Load the C# DLL
    let lib = unsafe { 
        Library::new("../../bin/NativeAOT/net8.0/win-x64/publish/StellarRPCSDK_Native.dll")?
    };

    // Start the server
    let start_server: Symbol<unsafe extern "C" fn()> = unsafe { lib.get(b"StartServer")? };
    unsafe { start_server() };

  // Create a connection to the server
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
    println!("Connection to SDK established.");

 // Create both the RPC client and specialized clients
    let mut network_client = NetworkProtoWrapperClient::new(channel.clone());
    let mut stellar_client = StellarClient::new(channel.clone());
    let mut muxed_client = MuxedAccountProtoWrapperClient::new(channel.clone());
    let mut xdr_client = XdrProtoServiceClient::new(channel.clone());
    let mut transaction_client = TransactionProtoWrapperClient::new(channel.clone());

    // Configure network first
    network_client.use_test_network(tonic::Request::new(())).await?;
    network_client.set_url(tonic::Request::new(stellar::SetUrlParam {
        url: "https://soroban-testnet.stellar.org".to_string()
    })).await?;
    
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

     if let Some(entry) = ledger_entries.into_inner().entries.first() {
        if let Some(ledger_entry_data) = &entry.ledger_entry_data {
            if let Some(stellar_rpc::ledger_entry_data_union::Subtype::LedgerEntryDataUnionAccount(account_data)) = &ledger_entry_data.subtype {
                if let Some(account) = &account_data.account {
                  if let Some(ref balance) = account.balance {
                        println!("Account balance: {}", balance.inner_value);
                    } else {
                        println!("Account balance is not available.");
                    }
                }
            }
        }
    }

    Ok(())
}
