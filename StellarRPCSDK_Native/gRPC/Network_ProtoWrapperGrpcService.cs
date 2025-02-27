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
    /// <summary>gRPC service descriptor for Network_ProtoWrapper</summary>
    public static class Network_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.Network_ProtoWrapper";

        /// <summary>Method descriptor for Create</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.CreateNetworkParam, Stellar.Network> CreateMethod =
            new Method<Stellar.Network_ProtoWrapper.CreateNetworkParam, Stellar.Network>(
                MethodType.Unary,
                ServiceName,
                "Create",
                Network_ProtoWrapperCreateNetworkParamGrpcMarshaller.CreateNetworkParamMarshaller,
                NetworkGrpcMarshaller.NetworkMarshaller);

        /// <summary>Method descriptor for GetNetworkPassphrase</summary>
        public static readonly Method<Stellar.Network, Stellar.StringWrapper> GetNetworkPassphraseMethod =
            new Method<Stellar.Network, Stellar.StringWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetNetworkPassphrase",
                NetworkGrpcMarshaller.NetworkMarshaller,
                StringWrapperGrpcMarshaller.StringWrapperMarshaller);

        /// <summary>Method descriptor for IsPublicNetwork</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.IsPublicNetworkParam, Stellar.BoolWrapper> IsPublicNetworkMethod =
            new Method<Stellar.Network_ProtoWrapper.IsPublicNetworkParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsPublicNetwork",
                Network_ProtoWrapperIsPublicNetworkParamGrpcMarshaller.IsPublicNetworkParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

    }

    /// <summary>Custom marshallers for Network_ProtoWrapper types</summary>
    public static class Network_ProtoWrapperGrpcMarshaller
    {
        // Static constructor to configure types
        static Network_ProtoWrapperGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Ensure types are configured for AOT compatibility
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.CreateNetworkParam)))
            {
                model.Add(typeof(Stellar.Network_ProtoWrapper.CreateNetworkParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.Network)))
            {
                model.Add(typeof(Stellar.Network), true);
            }
            if (!model.IsDefined(typeof(Stellar.StringWrapper)))
            {
                model.Add(typeof(Stellar.StringWrapper), true);
            }
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.IsPublicNetworkParam)))
            {
                model.Add(typeof(Stellar.Network_ProtoWrapper.IsPublicNetworkParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.BoolWrapper)))
            {
                model.Add(typeof(Stellar.BoolWrapper), true);
            }
 

        }

        /// <summary>Marshaller for CreateNetworkParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.CreateNetworkParam> CreateNetworkParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.CreateNetworkParam>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.CreateNetworkParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for Network</summary>
        public static readonly Marshaller<Stellar.Network> NetworkMarshaller = Marshallers.Create<Stellar.Network>(
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
                        return Serializer.Deserialize<Stellar.Network>(ms);
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

        /// <summary>Marshaller for IsPublicNetworkParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.IsPublicNetworkParam> IsPublicNetworkParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.IsPublicNetworkParam>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.IsPublicNetworkParam>(ms);
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

        /// <summary>Marshaller for Object</summary>
        public static readonly Marshaller<System.Object> ObjectMarshaller = Marshallers.Create<System.Object>(
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
                        return Serializer.Deserialize<System.Object>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for Boolean</summary>
        public static readonly Marshaller<System.Boolean> BooleanMarshaller = Marshallers.Create<System.Boolean>(
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
                        return Serializer.Deserialize<System.Boolean>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }

    /// <summary>gRPC service implementation for Network_ProtoWrapper</summary>
    public class Network_ProtoWrapperGrpcService
    {
        private readonly Network_ProtoWrapper _service;
        private readonly ILogger _logger;

        public Network_ProtoWrapperGrpcService(Network_ProtoWrapper service, ILogger<Network_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for Create method</summary>
        public async Task<Stellar.Network> Create(Stellar.Network_ProtoWrapper.CreateNetworkParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing Create request");
                return _service.Create(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Create");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetNetworkPassphrase method</summary>
        public async Task<Stellar.StringWrapper> GetNetworkPassphrase(Stellar.Network request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetNetworkPassphrase request");
                return _service.GetNetworkPassphrase(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetNetworkPassphrase");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for IsPublicNetwork method</summary>
        public async Task<Stellar.BoolWrapper> IsPublicNetwork(Stellar.Network_ProtoWrapper.IsPublicNetworkParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing IsPublicNetwork request");
                return _service.IsPublicNetwork(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in IsPublicNetwork");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Equals method</summary>
        public async Task<System.Boolean> Equals(System.Object request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing Equals request");
                return _service.Equals(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Equals");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
