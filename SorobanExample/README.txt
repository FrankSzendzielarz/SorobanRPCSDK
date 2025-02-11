See the CSPROJ for details. This project replaces the BUILDS target 
with a Soroban build and deploy:

<Target Name="BuildAndDeployContracts" BeforeTargets="Build">
		<Exec Command="cd arithmetic &amp;&amp; cargo fmt --all" />
		<Exec Command="cd arithmetic &amp;&amp; soroban contract build --out-dir ../out" />
		<Exec Command="cd out &amp;&amp; soroban contract optimize --wasm ./arithmetic.wasm" />
		<Exec Command="cd out &amp;&amp; soroban contract deploy --rpc-url &quot;$(SOROBAN_RPC_URL)&quot; --network-passphrase &quot;$(SOROBAN_NETWORK_PASSPHRASE)&quot; --source-account &quot;$(SOROBAN_ACCOUNT)&quot; --wasm ./arithmetic.optimized.wasm" />
		<Exec Command="cd arithmetic &amp;&amp; cargo clean" />
</Target>

<Target Name="Build" />


The setEnvVars prepares the environment with the necessary variables. 
This needs to be run and then VS closed and re-opened.

Build or re-build this project and check the output window for the 
deployed contract Id, eg: CATC4YDHZ7JYWAHYSRQQGVQQRN3ZU7UFFCXEDY32AIADJDSDNKORLHBD

The output can be found in the out folder.

