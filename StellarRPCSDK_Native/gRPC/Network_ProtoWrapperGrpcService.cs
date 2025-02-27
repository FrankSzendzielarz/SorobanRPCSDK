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
    /// <summary>gRPC service descriptor for INetwork_ProtoWrapper</summary>
    public static class Network_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.Network_ProtoWrapper";

        /// <summary>Method descriptor for Create</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.CreateNetworkParam, Stellar.Network> Create =
            new Method<Stellar.Network_ProtoWrapper.CreateNetworkParam, Stellar.Network>(
                MethodType.Unary,
                ServiceName,
                "Create",
                Network_ProtoWrapperCreateNetworkParamGrpcMarshaller.Network_ProtoWrapper_CreateNetworkParamMarshaller,
                NetworkGrpcMarshaller.NetworkMarshaller);

        /// <summary>Method descriptor for GetCurrent</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network_ProtoWrapper.GetCurrentResult> GetCurrent =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network_ProtoWrapper.GetCurrentResult>(
                MethodType.Unary,
                ServiceName,
                "GetCurrent",
                EmptyGrpcMarshaller.EmptyMarshaller,
                Network_ProtoWrapperGetCurrentResultGrpcMarshaller.Network_ProtoWrapper_GetCurrentResultMarshaller);

        /// <summary>Method descriptor for GetNetworkPassphrase</summary>
        public static readonly Method<Stellar.Network, Stellar.StringWrapper> GetNetworkPassphrase =
            new Method<Stellar.Network, Stellar.StringWrapper>(
                MethodType.Unary,
                ServiceName,
                "GetNetworkPassphrase",
                NetworkGrpcMarshaller.NetworkMarshaller,
                StringWrapperGrpcMarshaller.StringWrapperMarshaller);

        /// <summary>Method descriptor for IsPublicNetwork</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.IsPublicNetworkParam, Stellar.BoolWrapper> IsPublicNetwork =
            new Method<Stellar.Network_ProtoWrapper.IsPublicNetworkParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsPublicNetwork",
                Network_ProtoWrapperIsPublicNetworkParamGrpcMarshaller.Network_ProtoWrapper_IsPublicNetworkParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for Public</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network> Public =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network>(
                MethodType.Unary,
                ServiceName,
                "Public",
                EmptyGrpcMarshaller.EmptyMarshaller,
                NetworkGrpcMarshaller.NetworkMarshaller);

        /// <summary>Method descriptor for Test</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network> Test =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.Network>(
                MethodType.Unary,
                ServiceName,
                "Test",
                EmptyGrpcMarshaller.EmptyMarshaller,
                NetworkGrpcMarshaller.NetworkMarshaller);

        /// <summary>Method descriptor for Use</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.UseParam, Google.Protobuf.WellKnownTypes.Empty> Use =
            new Method<Stellar.Network_ProtoWrapper.UseParam, Google.Protobuf.WellKnownTypes.Empty>(
                MethodType.Unary,
                ServiceName,
                "Use",
                Network_ProtoWrapperUseParamGrpcMarshaller.Network_ProtoWrapper_UseParamMarshaller,
                EmptyGrpcMarshaller.EmptyMarshaller);

        /// <summary>Method descriptor for UsePublicNetwork</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Google.Protobuf.WellKnownTypes.Empty> UsePublicNetwork =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Google.Protobuf.WellKnownTypes.Empty>(
                MethodType.Unary,
                ServiceName,
                "UsePublicNetwork",
                EmptyGrpcMarshaller.EmptyMarshaller,
                EmptyGrpcMarshaller.EmptyMarshaller);

        /// <summary>Method descriptor for UseTestNetwork</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Google.Protobuf.WellKnownTypes.Empty> UseTestNetwork =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Google.Protobuf.WellKnownTypes.Empty>(
                MethodType.Unary,
                ServiceName,
                "UseTestNetwork",
                EmptyGrpcMarshaller.EmptyMarshaller,
                EmptyGrpcMarshaller.EmptyMarshaller);

        /// <summary>Method descriptor for SetUrl</summary>
        public static readonly Method<Stellar.Network_ProtoWrapper.SetUrlParam, Google.Protobuf.WellKnownTypes.Empty> SetUrl =
            new Method<Stellar.Network_ProtoWrapper.SetUrlParam, Google.Protobuf.WellKnownTypes.Empty>(
                MethodType.Unary,
                ServiceName,
                "SetUrl",
                Network_ProtoWrapperSetUrlParamGrpcMarshaller.Network_ProtoWrapper_SetUrlParamMarshaller,
                EmptyGrpcMarshaller.EmptyMarshaller);

    }

    /// <summary>Custom marshallers for INetwork_ProtoWrapper types</summary>
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
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.GetCurrentResult)))
            {
                model.Add(typeof(Stellar.Network_ProtoWrapper.GetCurrentResult), true);
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
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.UseParam)))
            {
                model.Add(typeof(Stellar.Network_ProtoWrapper.UseParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.Network_ProtoWrapper.SetUrlParam)))
            {
                model.Add(typeof(Stellar.Network_ProtoWrapper.SetUrlParam), true);
            }

        }

        /// <summary>Marshaller for CreateNetworkParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.CreateNetworkParam> Network_ProtoWrapper_CreateNetworkParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.CreateNetworkParam>(
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

        /// <summary>Marshaller for GetCurrentResult</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.GetCurrentResult> Network_ProtoWrapper_GetCurrentResultMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.GetCurrentResult>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.GetCurrentResult>(ms);
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
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.IsPublicNetworkParam> Network_ProtoWrapper_IsPublicNetworkParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.IsPublicNetworkParam>(
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

        /// <summary>Marshaller for UseParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.UseParam> Network_ProtoWrapper_UseParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.UseParam>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.UseParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SetUrlParam</summary>
        public static readonly Marshaller<Stellar.Network_ProtoWrapper.SetUrlParam> Network_ProtoWrapper_SetUrlParamMarshaller = Marshallers.Create<Stellar.Network_ProtoWrapper.SetUrlParam>(
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
                        return Serializer.Deserialize<Stellar.Network_ProtoWrapper.SetUrlParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }

    /// <summary>gRPC service implementation for INetwork_ProtoWrapper</summary>
    public class Network_ProtoWrapperGrpcService
    {
        private readonly INetwork_ProtoWrapper _service;
        private readonly ILogger _logger;

        public Network_ProtoWrapperGrpcService(INetwork_ProtoWrapper service, ILogger<Network_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for Create method</summary>
        public async Task<Stellar.Network> Create(Stellar.Network_ProtoWrapper.CreateNetworkParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Create request");
                return _service.Create(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Create");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetCurrent method</summary>
        public async Task<Stellar.Network_ProtoWrapper.GetCurrentResult> GetCurrent(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing GetCurrent request");
                return _service.GetCurrent() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetCurrent");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetNetworkPassphrase method</summary>
        public async Task<Stellar.StringWrapper> GetNetworkPassphrase(Stellar.Network request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing GetNetworkPassphrase request");
                return _service.GetNetworkPassphrase(request) ;
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
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing IsPublicNetwork request");
                return _service.IsPublicNetwork(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in IsPublicNetwork");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Public method</summary>
        public async Task<Stellar.Network> Public(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Public request");
                return _service.Public() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Public");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Test method</summary>
        public async Task<Stellar.Network> Test(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Test request");
                return _service.Test() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Test");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Use method</summary>
        public async Task<Google.Protobuf.WellKnownTypes.Empty> Use(Stellar.Network_ProtoWrapper.UseParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Use request");
                _service.Use(request);
                return new Google.Protobuf.WellKnownTypes.Empty();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Use");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for UsePublicNetwork method</summary>
        public async Task<Google.Protobuf.WellKnownTypes.Empty> UsePublicNetwork(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing UsePublicNetwork request");
                _service.UsePublicNetwork();
                return new Google.Protobuf.WellKnownTypes.Empty();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in UsePublicNetwork");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for UseTestNetwork method</summary>
        public async Task<Google.Protobuf.WellKnownTypes.Empty> UseTestNetwork(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing UseTestNetwork request");
                _service.UseTestNetwork();
                return new Google.Protobuf.WellKnownTypes.Empty();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in UseTestNetwork");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for SetUrl method</summary>
        public async Task<Google.Protobuf.WellKnownTypes.Empty> SetUrl(Stellar.Network_ProtoWrapper.SetUrlParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing SetUrl request");
                _service.SetUrl(request);
                return new Google.Protobuf.WellKnownTypes.Empty();
            }
            catch (Exception ex)
            {  
                _logger.LogError(ex, "Error in SetUrl");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
