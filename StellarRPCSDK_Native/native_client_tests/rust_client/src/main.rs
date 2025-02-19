use libloading::{Library, Symbol};
use tonic::transport::{Channel, Uri};
use tower::service_fn;
use my_service::my_service_client::MyServiceClient;
use my_service::AddRequest;
use tokio::net::windows::named_pipe::ClientOptions;

pub mod my_service {
    tonic::include_proto!("native_tests");
}

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Load the C# DLL
    let lib = unsafe { 
        Library::new("../../bin/Release/net8.0/win-x64/publish/StellarRPCSDK_Native.dll")?
    };

    // Start the server
    let start_server: Symbol<unsafe extern "C" fn()> = unsafe { lib.get(b"StartServer")? };
    unsafe { start_server() };

  // Create a connection to the server
    #[cfg(target_os = "windows")]
    let channel = Channel::from_static("http://[::]")
        .connect_with_connector(service_fn(|_: Uri| async move {
            ClientOptions::new()
                .open(r"\\.\pipe\MyServicePipe")
        }))
        .await?;

    #[cfg(not(target_os = "windows"))]
    let channel = Channel::from_static("http://[::]")
        .connect_with_connector(service_fn(|_: Uri| async move {
            tokio::net::UnixStream::connect("/tmp/MyService.sock")
        }))
        .await?;

    // Create a gRPC client
    let mut client = MyServiceClient::new(channel);

    // Call the AddNumbers method
    let request = tonic::Request::new(AddRequest { a: 2, b: 3 });
    let response = client.add_numbers(request).await?;
    println!("Result: {}", response.into_inner().result);

    Ok(())
}
