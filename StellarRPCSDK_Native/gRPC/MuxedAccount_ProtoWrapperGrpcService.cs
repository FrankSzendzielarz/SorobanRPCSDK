// Generated code - do not modify directly
using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProtoBuf;
using ProtoBuf.Meta;
using System.IO;
using System.Buffers;
using Stellar;

namespace Stellar.RPC.AOT
{
    /// <summary>gRPC service descriptor for MuxedAccount_ProtoWrapper</summary>
    public static class MuxedAccount_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.MuxedAccount_ProtoWrapper";

        /// <summary>Method descriptor for GetPublicKey</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper> GetPublicKey =
            new Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetPublicKey",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller);

        /// <summary>Method descriptor for GetPrivateKey</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper> GetPrivateKey =
            new Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetPrivateKey",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller);

        /// <summary>Method descriptor for GetSeedBytes</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper> GetSeedBytes =
            new Method<Stellar.MuxedAccount, Stellar.ByteArrayWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetSeedBytes",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller);

        /// <summary>Method descriptor for GetSecretSeed</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.StringWrapper> GetSecretSeed =
            new Method<Stellar.MuxedAccount, Stellar.StringWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetSecretSeed",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                StringWrapperGrpcMarshaller.StringWrapperMarshaller);

        /// <summary>Method descriptor for GetAccountId</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.StringWrapper> GetAccountId =
            new Method<Stellar.MuxedAccount, Stellar.StringWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetAccountId",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                StringWrapperGrpcMarshaller.StringWrapperMarshaller);

        /// <summary>Method descriptor for GetAddress</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.StringWrapper> GetAddress =
            new Method<Stellar.MuxedAccount, Stellar.StringWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetAddress",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                StringWrapperGrpcMarshaller.StringWrapperMarshaller);

        /// <summary>Method descriptor for CanSign</summary>
        public static readonly Method<Stellar.MuxedAccount, Stellar.BoolWrapper> CanSign =
            new Method<Stellar.MuxedAccount, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "CanSign",
                MuxedAccountGrpcMarshaller.MuxedAccountMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for Sign</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.SignMessage, Stellar.ByteArrayWrapper> Sign =
            new Method<Stellar.MuxedAccount_ProtoWrapper.SignMessage, Stellar.ByteArrayWrapper>(
                MethodType.Unary,
                ServiceName,
                "Sign",
                MuxedAccount_ProtoWrapperSignMessageGrpcMarshaller.MuxedAccount_ProtoWrapper_SignMessageMarshaller,
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller);

        /// <summary>Method descriptor for Verify</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage, Stellar.BoolWrapper> Verify =
            new Method<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "Verify",
                MuxedAccount_ProtoWrapperVerifyMessageGrpcMarshaller.MuxedAccount_ProtoWrapper_VerifyMessageMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for CreateKeyTypeEd25519</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param, Stellar.MuxedAccount.KeyTypeEd25519> CreateKeyTypeEd25519 =
            new Method<Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "CreateKeyTypeEd25519",
                MuxedAccount_ProtoWrapperCreateEd25519ParamGrpcMarshaller.MuxedAccount_ProtoWrapper_CreateEd25519ParamMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for CreateKeyTypeMuxedEd25519</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param, Stellar.MuxedAccount.KeyTypeMuxedEd25519> CreateKeyTypeMuxedEd25519 =
            new Method<Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param, Stellar.MuxedAccount.KeyTypeMuxedEd25519>(
                MethodType.Unary,
                ServiceName,
                "CreateKeyTypeMuxedEd25519",
                MuxedAccount_ProtoWrapperCreateMuxedEd25519ParamGrpcMarshaller.MuxedAccount_ProtoWrapper_CreateMuxedEd25519ParamMarshaller,
                MuxedAccountKeyTypeMuxedEd25519GrpcMarshaller.MuxedAccount_KeyTypeMuxedEd25519Marshaller);

        /// <summary>Method descriptor for FromSecretSeed</summary>
        public static readonly Method<Stellar.StringWrapper, Stellar.MuxedAccount.KeyTypeEd25519> FromSecretSeed =
            new Method<Stellar.StringWrapper, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromSecretSeed",
                StringWrapperGrpcMarshaller.StringWrapperMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for FromSecretSeedBytes</summary>
        public static readonly Method<Stellar.ByteArrayWrapper, Stellar.MuxedAccount.KeyTypeEd25519> FromSecretSeedBytes =
            new Method<Stellar.ByteArrayWrapper, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromSecretSeedBytes",
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for FromAccountId</summary>
        public static readonly Method<Stellar.StringWrapper, Stellar.MuxedAccount.KeyTypeEd25519> FromAccountId =
            new Method<Stellar.StringWrapper, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromAccountId",
                StringWrapperGrpcMarshaller.StringWrapperMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for FromPublicKey</summary>
        public static readonly Method<Stellar.ByteArrayWrapper, Stellar.MuxedAccount.KeyTypeEd25519> FromPublicKey =
            new Method<Stellar.ByteArrayWrapper, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromPublicKey",
                ByteArrayWrapperGrpcMarshaller.ByteArrayWrapperMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for FromBIP39Seed</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam, Stellar.MuxedAccount.KeyTypeEd25519> FromBIP39Seed =
            new Method<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromBIP39Seed",
                MuxedAccount_ProtoWrapperBIP39SeedParamGrpcMarshaller.MuxedAccount_ProtoWrapper_BIP39SeedParamMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for FromBIP39SeedBytes</summary>
        public static readonly Method<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam, Stellar.MuxedAccount.KeyTypeEd25519> FromBIP39SeedBytes =
            new Method<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "FromBIP39SeedBytes",
                MuxedAccount_ProtoWrapperBIP39SeedBytesParamGrpcMarshaller.MuxedAccount_ProtoWrapper_BIP39SeedBytesParamMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

        /// <summary>Method descriptor for Random</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.MuxedAccount.KeyTypeEd25519> Random =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.MuxedAccount.KeyTypeEd25519>(
                MethodType.Unary,
                ServiceName,
                "Random",
                EmptyGrpcMarshaller.EmptyMarshaller,
                MuxedAccountKeyTypeEd25519GrpcMarshaller.MuxedAccount_KeyTypeEd25519Marshaller);

    }

    /// <summary>Custom marshallers for MuxedAccount_ProtoWrapper types</summary>
    public static class MuxedAccount_ProtoWrapperGrpcMarshaller
    {
        // Static constructor to configure types
        static MuxedAccount_ProtoWrapperGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Ensure types are configured for AOT compatibility
            if (!model.IsDefined(typeof(Stellar.MuxedAccount)))
            {
                model.Add(typeof(Stellar.MuxedAccount), true);
            }
            if (!model.IsDefined(typeof(Stellar.ByteArrayWrapper)))
            {
                model.Add(typeof(Stellar.ByteArrayWrapper), true);
            }
            if (!model.IsDefined(typeof(Stellar.StringWrapper)))
            {
                model.Add(typeof(Stellar.StringWrapper), true);
            }
            if (!model.IsDefined(typeof(Stellar.BoolWrapper)))
            {
                model.Add(typeof(Stellar.BoolWrapper), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.SignMessage)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.SignMessage), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.VerifyMessage)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.VerifyMessage), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount.KeyTypeEd25519)))
            {
                model.Add(typeof(Stellar.MuxedAccount.KeyTypeEd25519), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount.KeyTypeMuxedEd25519)))
            {
                model.Add(typeof(Stellar.MuxedAccount.KeyTypeMuxedEd25519), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam)))
            {
                model.Add(typeof(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam), true);
            }

        }

        /// <summary>Marshaller for MuxedAccount</summary>
        public static readonly Marshaller<Stellar.MuxedAccount> MuxedAccountMarshaller = Marshallers.Create<Stellar.MuxedAccount>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for ByteArrayWrapper</summary>
        public static readonly Marshaller<Stellar.ByteArrayWrapper> ByteArrayWrapperMarshaller = Marshallers.Create<Stellar.ByteArrayWrapper>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.ByteArrayWrapper>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for StringWrapper</summary>
        public static readonly Marshaller<Stellar.StringWrapper> StringWrapperMarshaller = Marshallers.Create<Stellar.StringWrapper>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.StringWrapper>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for BoolWrapper</summary>
        public static readonly Marshaller<Stellar.BoolWrapper> BoolWrapperMarshaller = Marshallers.Create<Stellar.BoolWrapper>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.BoolWrapper>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SignMessage</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.SignMessage> MuxedAccount_ProtoWrapper_SignMessageMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.SignMessage>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.SignMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for VerifyMessage</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage> MuxedAccount_ProtoWrapper_VerifyMessageMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.VerifyMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for CreateEd25519Param</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param> MuxedAccount_ProtoWrapper_CreateEd25519ParamMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for KeyTypeEd25519</summary>
        public static readonly Marshaller<Stellar.MuxedAccount.KeyTypeEd25519> MuxedAccount_KeyTypeEd25519Marshaller = Marshallers.Create<Stellar.MuxedAccount.KeyTypeEd25519>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount.KeyTypeEd25519>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for CreateMuxedEd25519Param</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param> MuxedAccount_ProtoWrapper_CreateMuxedEd25519ParamMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for KeyTypeMuxedEd25519</summary>
        public static readonly Marshaller<Stellar.MuxedAccount.KeyTypeMuxedEd25519> MuxedAccount_KeyTypeMuxedEd25519Marshaller = Marshallers.Create<Stellar.MuxedAccount.KeyTypeMuxedEd25519>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount.KeyTypeMuxedEd25519>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for BIP39SeedParam</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam> MuxedAccount_ProtoWrapper_BIP39SeedParamMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for BIP39SeedBytesParam</summary>
        public static readonly Marshaller<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam> MuxedAccount_ProtoWrapper_BIP39SeedBytesParamMarshaller = Marshallers.Create<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }

    /// <summary>gRPC service implementation for MuxedAccount_ProtoWrapper</summary>
    public class MuxedAccount_ProtoWrapperGrpcService
    {
        private readonly MuxedAccount_ProtoWrapper _service;
        private readonly ILogger _logger;

        public MuxedAccount_ProtoWrapperGrpcService(MuxedAccount_ProtoWrapper service, ILogger<MuxedAccount_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for GetPublicKey method</summary>
        public async Task<Stellar.ByteArrayWrapper> GetPublicKey(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetPublicKey request");
                return _service.GetPublicKey(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetPublicKey");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetPrivateKey method</summary>
        public async Task<Stellar.ByteArrayWrapper> GetPrivateKey(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetPrivateKey request");
                return _service.GetPrivateKey(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetPrivateKey");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetSeedBytes method</summary>
        public async Task<Stellar.ByteArrayWrapper> GetSeedBytes(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetSeedBytes request");
                return _service.GetSeedBytes(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetSeedBytes");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetSecretSeed method</summary>
        public async Task<Stellar.StringWrapper> GetSecretSeed(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetSecretSeed request");
                return _service.GetSecretSeed(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetSecretSeed");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetAccountId method</summary>
        public async Task<Stellar.StringWrapper> GetAccountId(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetAccountId request");
                return _service.GetAccountId(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAccountId");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetAddress method</summary>
        public async Task<Stellar.StringWrapper> GetAddress(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetAddress request");
                return _service.GetAddress(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAddress");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for CanSign method</summary>
        public async Task<Stellar.BoolWrapper> CanSign(Stellar.MuxedAccount request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing CanSign request");
                return _service.CanSign(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CanSign");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Sign method</summary>
        public async Task<Stellar.ByteArrayWrapper> Sign(Stellar.MuxedAccount_ProtoWrapper.SignMessage request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing Sign request");
                return _service.Sign(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Sign");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Verify method</summary>
        public async Task<Stellar.BoolWrapper> Verify(Stellar.MuxedAccount_ProtoWrapper.VerifyMessage request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing Verify request");
                return _service.Verify(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Verify");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for CreateKeyTypeEd25519 method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> CreateKeyTypeEd25519(Stellar.MuxedAccount_ProtoWrapper.CreateEd25519Param request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing CreateKeyTypeEd25519 request");
                return _service.CreateKeyTypeEd25519(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CreateKeyTypeEd25519");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for CreateKeyTypeMuxedEd25519 method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeMuxedEd25519> CreateKeyTypeMuxedEd25519(Stellar.MuxedAccount_ProtoWrapper.CreateMuxedEd25519Param request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing CreateKeyTypeMuxedEd25519 request");
                return _service.CreateKeyTypeMuxedEd25519(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CreateKeyTypeMuxedEd25519");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromSecretSeed method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromSecretSeed(Stellar.StringWrapper request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromSecretSeed request");
                return _service.FromSecretSeed(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromSecretSeed");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromSecretSeedBytes method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromSecretSeedBytes(Stellar.ByteArrayWrapper request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromSecretSeedBytes request");
                return _service.FromSecretSeedBytes(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromSecretSeedBytes");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromAccountId method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromAccountId(Stellar.StringWrapper request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromAccountId request");
                return _service.FromAccountId(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromAccountId");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromPublicKey method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromPublicKey(Stellar.ByteArrayWrapper request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromPublicKey request");
                return _service.FromPublicKey(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromPublicKey");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromBIP39Seed method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromBIP39Seed(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromBIP39Seed request");
                return _service.FromBIP39Seed(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromBIP39Seed");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for FromBIP39SeedBytes method</summary>
        public async Task<Stellar.MuxedAccount.KeyTypeEd25519> FromBIP39SeedBytes(Stellar.MuxedAccount_ProtoWrapper.BIP39SeedBytesParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing FromBIP39SeedBytes request");
                return _service.FromBIP39SeedBytes(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FromBIP39SeedBytes");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
