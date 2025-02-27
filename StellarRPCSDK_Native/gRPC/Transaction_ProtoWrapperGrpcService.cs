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
    /// <summary>gRPC service descriptor for Transaction_ProtoWrapper</summary>
    public static class Transaction_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.Transaction_ProtoWrapper";

        /// <summary>Method descriptor for Sign</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.SignParam, Stellar.DecoratedSignature> SignMethod =
            new Method<Stellar.Transaction_ProtoWrapper.SignParam, Stellar.DecoratedSignature>(
                MethodType.Unary,
                ServiceName,
                "Sign",
                Transaction_ProtoWrapperSignParamGrpcMarshaller.SignParamMarshaller,
                DecoratedSignatureGrpcMarshaller.DecoratedSignatureMarshaller);

        /// <summary>Method descriptor for Clone</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.CloneParam, Stellar.Transaction> CloneMethod =
            new Method<Stellar.Transaction_ProtoWrapper.CloneParam, Stellar.Transaction>(
                MethodType.Unary,
                ServiceName,
                "Clone",
                Transaction_ProtoWrapperCloneParamGrpcMarshaller.CloneParamMarshaller,
                TransactionGrpcMarshaller.TransactionMarshaller);

        /// <summary>Method descriptor for IsSoroban</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper> IsSorobanMethod =
            new Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsSoroban",
                Transaction_ProtoWrapperIsSorobanParamGrpcMarshaller.IsSorobanParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for IsSorobanInvocation</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper> IsSorobanInvocationMethod =
            new Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsSorobanInvocation",
                Transaction_ProtoWrapperIsSorobanParamGrpcMarshaller.IsSorobanParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

    }

    /// <summary>Custom marshallers for Transaction_ProtoWrapper types</summary>
    public static class Transaction_ProtoWrapperGrpcMarshaller
    {
        // Static constructor to configure types
        static Transaction_ProtoWrapperGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Ensure types are configured for AOT compatibility
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.SignParam)))
            {
                model.Add(typeof(Stellar.Transaction_ProtoWrapper.SignParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.DecoratedSignature)))
            {
                model.Add(typeof(Stellar.DecoratedSignature), true);
            }
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.CloneParam)))
            {
                model.Add(typeof(Stellar.Transaction_ProtoWrapper.CloneParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.Transaction)))
            {
                model.Add(typeof(Stellar.Transaction), true);
            }
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.IsSorobanParam)))
            {
                model.Add(typeof(Stellar.Transaction_ProtoWrapper.IsSorobanParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.BoolWrapper)))
            {
                model.Add(typeof(Stellar.BoolWrapper), true);
            }


        }

        /// <summary>Marshaller for SignParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.SignParam> SignParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.SignParam>(
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
                        return Serializer.Deserialize<Stellar.Transaction_ProtoWrapper.SignParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for DecoratedSignature</summary>
        public static readonly Marshaller<Stellar.DecoratedSignature> DecoratedSignatureMarshaller = Marshallers.Create<Stellar.DecoratedSignature>(
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
                        return Serializer.Deserialize<Stellar.DecoratedSignature>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for CloneParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.CloneParam> CloneParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.CloneParam>(
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
                        return Serializer.Deserialize<Stellar.Transaction_ProtoWrapper.CloneParam>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for Transaction</summary>
        public static readonly Marshaller<Stellar.Transaction> TransactionMarshaller = Marshallers.Create<Stellar.Transaction>(
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
                        return Serializer.Deserialize<Stellar.Transaction>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for IsSorobanParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.IsSorobanParam> IsSorobanParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.IsSorobanParam>(
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
                        return Serializer.Deserialize<Stellar.Transaction_ProtoWrapper.IsSorobanParam>(ms);
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

    /// <summary>gRPC service implementation for Transaction_ProtoWrapper</summary>
    public class Transaction_ProtoWrapperGrpcService
    {
        private readonly Transaction_ProtoWrapper _service;
        private readonly ILogger _logger;

        public Transaction_ProtoWrapperGrpcService(Transaction_ProtoWrapper service, ILogger<Transaction_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for Sign method</summary>
        public async Task<Stellar.DecoratedSignature> Sign(Stellar.Transaction_ProtoWrapper.SignParam request, ServerCallContext context)
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

        /// <summary>Handler for Clone method</summary>
        public async Task<Stellar.Transaction> Clone(Stellar.Transaction_ProtoWrapper.CloneParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing Clone request");
                return _service.Clone(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Clone");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for IsSoroban method</summary>
        public async Task<Stellar.BoolWrapper> IsSoroban(Stellar.Transaction_ProtoWrapper.IsSorobanParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing IsSoroban request");
                return _service.IsSoroban(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in IsSoroban");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for IsSorobanInvocation method</summary>
        public async Task<Stellar.BoolWrapper> IsSorobanInvocation(Stellar.Transaction_ProtoWrapper.IsSorobanParam request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing IsSorobanInvocation request");
                return _service.IsSorobanInvocation(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in IsSorobanInvocation");
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
