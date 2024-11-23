# Cross Platform Soroban RPC SDK
A lightweight SDK for cross platform and native consumption of the Stellar Soroban RPC gateway.

## Motivations
We are developing a larger, private project using Stellar exclusively as the transaction processing platform. The architecture
involves server components using Soroban RPC as the entrypoint to the Stellar network, in communication with native front-ends, initially 
targetting Android, iOS, Tizen OS for Smart TVs (and later potential Samsung smart wearables). Post-MVP the project includes Unity
native game development, WASM web, and more. 

During MVP development we encountered a range of time-consuming issues with the available SDKs that we had to address by
implementing ad-hoc solutions. We can now assemble these into a cohesive SDK and offer it back to the Stellar community. 


### Current SDK Challenges
Developing Smart TV apps typically requires the .NET platform. For cross platform native apps using Xamarin.Forms or MAUI, targetting desktop, mobile or others, the .NET SDK is required. Unity game 
development also requires the .NET platform. Server apps on .NET would need the .NET SDK. However, there are a range of issues with the current Stellar tooling for these scenarios
that we encountered:

- .NET Stellar SDK does not have or document an AssembleTransaction implementation and forces the developer to research the other SDKs, such as JS.

- SDK has no direct support or documentation for signing Soroban Authorisations, extracting Soroban authorisations for client signing.

- No up to date Unity SDK (the current Unity SDK is a four year old SDK that is archived).

- SDK does not work in the Unity Editor, as Newtonsoft JSON (a dependency) clashes with the Unity Editor.

- SDK does not work on Samsung Smart TVs due to dependency on native NaCl binary.

- SDK causes issues with cross-platform native development (iOS, Android) due to NaCl binary, using MAUI/Xamarin.

- .NET Stellar SDK is overkill for basic native scenarios:
  - Create account.
  - Get account balance.
  - Make a transaction.
  - Authorise a Soroban operation.
  - Get ledger entries.
	
- SDK bloat results from a design pattern that necessitates manual maintenance. The SDK consequently suffers from a certain degree of neglect.
 

### Why is a lightweight .NET SDK for Soroban important?

- Allows developers to quickly get started with the following straight away and with little learning curve, for the basic scenarios of account usage, transaction execution and 
Soroban contract interaction:

  - Unity game client development.
  - Smart TV app development.
  - .NET cross-platform native (Xamarin, MAUI) development.
  - .NET server development.

- By making it simple to quickly get started with Stellar on Smart TVs, Unity games and other .NET based projects, Stellar broadens its reach, while developers
get to experience Stellar.

- Allows automatic maintenance based on the JSON RPC and XDR specs.
 
- Offers a design pattern that allows for manual extension not affected by code-gen. The community can add utilities and other features independent of the XDR / OpenRPC artifacts.


### Other motivations

Today, .NET 8 and later (formerly .NET Core) is a very different platform than the Windows-based technology some might remember. .NET projects compile
to Linux, MacOS, Windows, iOS, Android and more, on all the major CPU architectures. 

By using .NET's existing tooling to automatically generate **protobuf** and possibly **gRPC** specifications corresponding to the C# classes and Soroban RPC API, 
it is possible to offer a secondary interface allowing static binary linking. This means the SDK could be a **generally useful SDK for all platforms**, albeit
without the ability to debug into the SDK itself, but with the advantage of being automatically maintained.

## Design

### XDR Wrapping Overhead Solution

The current .NET SDK for Stellar adds overhead that also requires manual maintenance. While that might be useful for more complex
business logic abstracted across Horizon and Soroban RPC, it is not necessary for the purposes of this lightweight SDK. 

In this example, the SDK is providing two classes, a manually defind `LedgerKeyClaimableBalance` and a code-generated `Xdr.LedgerKeyClaimableBalance`. 

[PICTURE: The classes side by side]

The types are separated for the sole benefit of offering the user the convenience of avoiding switching on the `Discriminant`. However, 
this comes with the additional footprint of extra classes, extra references, and that the wrapper class is manually updated.

In this case, **our design is that only the XDR code generated C# class will be made available**.

In some instances the SDK wrapper classes implement utility functions. Here we see the same pattern as before except the wrapper class is
providing a helper `CanonicalName` for the `Asset` class:

[PICTURE: The classes side by side]

In C#, it is not necessary to introduce additional wrapper classes and memory footprint to augment code-generated classes with manual functionality.
Instead, **our design uses the `partial` keyword to declare partial classes**, A C# partial class allows a class to be defined across 
multiple file system files. The code generated part can be updated, while a separate project folder allows the community to
continue to introduce new utilities and helpers without fear of changes being overwritten by the code generator, and without the overhead
of the more abstract domain objects.

[PICTURE: The partial classes side by side]

### Automated Maintenance

The OpenRPC specification for the Soroban RPC Server will be fed into a custom tool for this project that yields a C# client class,
and separate classes for the RPC requests, responses, and any other nested classes they define.

Simultaneously, Stellar's XDRGEN is invoked to produce the XDR classes into the correct folder for the auto-generated `partials`. 
XDRGEN itself will be forked to add the 'generate partials' template or option. 

Finally, the SDK will specify an additional partial class for the client request/response messages themselves, adding the XDR classes, such
as ledger entries, transactions and so on, so that properties like the below highlighted are not needed by the user:

[PICTURE: The client class with the XDR string , and a new field with the XDR object ]

Rather than a GitHub action, the SDK will include a tool or script that can be executed locally to update the source, allow the maintainer
to check build, compensate in manually updateable partials, and submit changes to the repository via git. This simple script will behave
as follows:

[PICTURE: The 3 inputs of OpenRPC Gen, XDRGEN (slight mod), Client Class]

### Native Platform Dependency Restrictions and Unity Build

As described earlier, there are a number of issues with SDK library dependencies. On Smart TV and in some cross platform native scenarios,
the native Sodium lib cannot be loaded. On Smart TV non-emulator environments other dependencies are restricted from runtime load. In the
Unity Editor some libraries such as NewtonsoftJson clash with the editor itself, and the Unity Editor also benefits from class properties
having runtime metadata that make object properties easily edited.

In our current project we used a number of solutions depending on the circumstance, which we can pack up into this SDK:

- **IL Weaving** dependencies into the main assembly. A sophisticated technique called "IL weaving" allows the intermediate .NET
bytecode of the dependent assemblies to be re-scoped and renamed, so that they can be included into the parent library. From the
perspective of Tizen OS or Unity Editor, the library dependency no longer exists - only one library is loaded.
- A **skeleton Tizen OS app** offering a boilerplate ready-to-go Smart TV app will be produced that shows the special way needed to load
the SDK, and obviates dealing with the problem at all if directly modifying the project.
- A **separate Unity build configuration** will add the Unity Editor metadata for object properties, should they be needed in the editor itself.
- A **pure C# ed25519** library was used instead of the full Sodium lib, as the SDK really only needs `KeyPair`s, some hashing and signing. This
removes the need for native binary dependencies in the first place.


### Utility Functions

A limited suite of utility functions will be included:

- Soroban Authorisation usage and signing.
- Signing and Hashing in general.
- AssembleTransaction functionality (based on Simulation).

(Skeleton boilerplate apps will be produced to explain how to do basic tasks, like getting the Account balance or invoking a Soroban
function.)

### Possible Universal Static Linked Binary SDK

To broaden utility and appeal even further, the SDK build process can automatically produce a `gRPC` `protobuf` specification for the C# classes
resulting from the XDR and OpenRPC generation. The SDK will also be compiled to a number of native binaries and provided for 
platform-agnostic static linking. The client can link the binary, and use `protobuf` generated message objects to communicate with it.

The SDK would include an interface definition allowing the native client to pass in a reference to their own `HTTP client`. The
SDK would therefore use the platform's own and client's own HTTP tooling to connect to Soroban RPC.

[PICTURE: The build process, along with the client executable linking the assembly , and client software including classes generated
from the protobuf / grpc ]

Some further proof of concept work needs to be done to check what is possible here, and if gRPC can be used for in-process channels.


## Deliverables

With the above design, motivation and given what we have already developed in the scope of the enveloping project, we can confidently offer
the following deliverables:

- **A .NET lightweight, automatically maintained Soroban RPC SDK** enabling development with
  -  Tizen OS for Smart TV and Samsung wearables, and light access to Soroban RPC instances.
  -  Cross-platform native development on
     - Android.
     - iOS.
     - Windows.
     - Mac Catalyst.
     - Later Tizen OS versions using MAUI.
- **A tool to automate updates to the SDK**
  - OpenRPC -> C# class and client generator.
  - Slight variation to XDRGEN to allow `partials`.
  - Tool or script to generate all artifacts based on updated OpenRPC and XDR.
- **A build variant specifically for Unity**
  - No editor clashes.
  - Up-to-date (the current [Unity Stellar SDK](https://github.com/Kirbyrawr/stellar-sdk-unity) has *not been touched in four years*, and does not seem to include source).
  - Editor-friendly property metadata.
- **Boilerplate applications**
  - Get up and running with Samsung Smart TV straight away.
  - Get up and running with MAUI cross-platform native apps straight away.
- **Sample usage console app**
  - This would actually double as an end to end test app, but would show usage of all the intended scenarios, such as account creation, Soroban interaction and so on.
- **Attempted universal SDK**
  - Initial research says this is very likely achievable, that the native binary builds could be delivered along with an automated `gRPC/protobuf` spec.
  - A simple platform native example app using the SDK would be provided, such as for example a GoLang app statically linking the SDK.
- **Documentation**
  - Basic technical documentation and repo maintenance will be provided.
	 
	
All would be delivered in a single github repo, public, under an open-source license, such as MIT, or whatever the Stellar Community prefers.

