# Cross Platform Soroban RPC SDK
A lightweight SDK for cross platform and native consumption of the Stellar Soroban RPC gateway.

[AI generated summary here](README-Claude.md)

## Motivations
We are developing a larger, privately funded project using Stellar exclusively as the transaction processing platform. The architecture
involves server components using Soroban RPC server as the entrypoint to the Stellar network, in communication with native front-ends, initially 
targetting Android, iOS, Tizen OS for Smart TVs (and later potential Samsung smart wearables). Post-MVP the project includes Unity
native game development, WASM web, and more. 

One of the hurdles was the lack of SDK compatibility or documentation for the platforms targetted: Tizen smart TV apps, for instance, embrace the development community through .NET,
while the current SDKs for Stellar use NaCl native libraries that for obscure reasons do not 
work on production TV sets (but, confusingly, do on emulators). Some libraries referenced by the SDKs are not permitted as runtime dependencies and cause 
runtime load errors. For Android and iOS cross-platform there are similar compatibility headaches. Unity game development is done
with .NET and C#, also on the post-MVP roadmap, and suffers from the same kind of difficulty: the SDK lacks Unity Editor property
metadata and fails at design-time because of dependent assemblies that conflict with the editor (eg Newtonsoft Json serialisation). 
Also, the SDKs and documentation miss new functional areas related to Soroban, such as assembling a transaction after simulation, or allowing clients to sign
Soroban authorisation invocations easily. 

A lot of time was spent trying to understand how these obstacles could be overcome. 

The end result is a loose set of software components assembled to meet the goals of the project MVP. We decided that we could 
package this into a lightweight, compact SDK that gives back to the community. Further, we believe we could automate the 
maintenance process, to at least provide a gateway to Stellar through Soroban RPC in perpetuity without our continued participation.

## Goals

### Minimum Deliverable
Initially the idea was to produce a .NET Core SDK for Soroban RPC servers, targetting **.NET Standard 2.0**, which could be used for:

- Tizen OS , Smart TV and Samsung wearable, lightweight access to Soroban RPC instances
- Cross platform native development 
	- Android
	- iOS
	- Windows
	- Mac Catalyst 
	- Later Tizen (using MAUI)

This minimum goal would be automated by ingesting the JSON RPC for Soroban RPC, XDR specs from Stellar, and merging into the hardcoded parts.
The manually coded functionality would address:

-  Crypto functions 
	-  Hashing
	-  Ed25119 signing (not dependent on NaCl binaries)
-  Helper utilities
	- Soroban Authorisation signing
	- Transaction generation from Simulation

### Minimum Deliverable - Unity

Unity however requires some additional customisation. Metadata for the Unity Editor requires entity properties to be decorated
using a proprietary Unity library. Dependent libraries that conflict with the Unity Editor for design time game integration
with Stellar (such as Newtonsoft) must be internalised to the SDK using obscure techniques like IL-weaving. Thankfully, this
is something we have already achieved with other Unity libraries, and just needs to be repeated here.

This deliverable would involve a different build process and different output artifact, but would still be part of the minimum
we could offer.

NB: There is an existing [Unity SDK](https://github.com/Kirbyrawr/stellar-sdk-unity), but is a 4 year old, archive version of the
.NET SDK, while even the most up to date SDK lacked some Soroban features we needed.

### Extended Deliverables

On reflection, it became clear that with a .NET implementation of this, doorways open to some other deliverables that would
greatly broaden the reach. It seems at this point the cost/benefit could be worth it - adding a little complexity
to get something much more accessible and without drawing resources too much from the main project.

.NET code can now be compiled to AOT native binaries for most common platforms and CPU architecures. The modern compile process for .NET
allows the team to specify targets, such as Linux x64, and even generate single-file executables where the parts of the platform
specific runtime are embedded. A link-time process called 'trimming' then cuts out anything unnecessary, essentially outputting a
native app for the device being considered.

When the SDK we propose is added into another *.NET based* project (such as Samsung Smart TV, Android/ios/windows native cross platform, etc), all the Stellar objects, such as Ledger Entries, Transactions and so on,
are immediately available to the .NET developer. The Soroban RPC interface is immediately available as methods. **getLedgerEntries**,
**simulateTransaction** and the various **operations** . But for developers in other environments, using Swift, Kotlin, Objective C, Java
or more, all they would be getting is a statically linked binary without a clear way of interfacing with it. To them, a native binary output based on the minimum deliverable would not be of great benefit.

However, it seems we can solve that and we could help extend the native binary SDK's reach even further
with:

- An in-process channel exposed with automatically generated metadata using, probably, protobuf
	- Allows a developer to statically link the SDK
	- Generate client classes using protobuf
	- The SDK entities corresponding to the protobuf entities would already implement the XDR / JSON RPC marshalling as per minimum deliverable
	- The SDK entities would try to "fill in the blanks" regarding protobuf vs XDR constraints, validating array lengths and so on
	- Communicate with a Stellar Soroban RPC instance natively, on any platform, with little effort.

- A version of the SDK with an embedded Kestrel server
	- Run the SDK instead as an out of process executable
	- Use it as a proxy or shim
	- It would expose a gRPC endpoint
	- It would expose a HTTP WebAPI endpoint, with a SwaggerUI and OpenAPI spec
	- Both offering more options to clients to integrate with Soroban RPC
	- Could run natively alongside the client app, but with differing levels of ease depending on the scenario


### Common Deliverable

The SDK would respond to upstream changes in the Soroban RPC and XDR specs automatically. A github action would allow 
updates, generating code and compiling, or a similar mechanism. This is simple and lightweight enough that little manual intervention
should be required.


### Current State

Some of the minimum components already exist as disparate functions in a private repo, for a larger project.
The effort would be towards assembling these to be useful for the broader community, enabling them to approach platforms
the same way we have, researching and implementing the extended deliverables, and above all making sure the SDK does not
need manual maintenance.

Funding is basically indirect funding for the larger effort, which uses Stellar exclusively for transaction processing.
That main project must be developed in privacy for the time being, in order not to incentivise competition, particularly 
from other chains, and is being prepared for discussion with SDF, as the project is exclusively Stellar based.
