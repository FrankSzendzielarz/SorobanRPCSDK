fn main() -> Result<(), Box<dyn std::error::Error>> {
    tonic_build::configure()
        .build_client(true)
        .build_server(true)
        .compile(&["../../Stellar.proto", "../../Stellar.RPC.proto"], &["../../"])?;
    Ok(())
}