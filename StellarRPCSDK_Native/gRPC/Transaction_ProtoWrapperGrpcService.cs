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
    /// <summary>gRPC service descriptor for ITransaction_ProtoWrapper</summary>
    public static class Transaction_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.Transaction_ProtoWrapper";

        /// <summary>Method descriptor for Clone</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.CloneParam, Stellar.Transaction> Clone =
            new Method<Stellar.Transaction_ProtoWrapper.CloneParam, Stellar.Transaction>(
                MethodType.Unary,
                ServiceName,
                "Clone",
                Transaction_ProtoWrapperCloneParamGrpcMarshaller.Transaction_ProtoWrapper_CloneParamMarshaller,
                TransactionGrpcMarshaller.TransactionMarshaller);

        /// <summary>Method descriptor for IsSoroban</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper> IsSoroban =
            new Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsSoroban",
                Transaction_ProtoWrapperIsSorobanParamGrpcMarshaller.Transaction_ProtoWrapper_IsSorobanParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for IsSorobanInvocation</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper> IsSorobanInvocation =
            new Method<Stellar.Transaction_ProtoWrapper.IsSorobanParam, Stellar.BoolWrapper>(
                MethodType.Unary,
                ServiceName,
                "IsSorobanInvocation",
                Transaction_ProtoWrapperIsSorobanParamGrpcMarshaller.Transaction_ProtoWrapper_IsSorobanParamMarshaller,
                BoolWrapperGrpcMarshaller.BoolWrapperMarshaller);

        /// <summary>Method descriptor for Sign</summary>
        public static readonly Method<Stellar.Transaction_ProtoWrapper.SignParam, Stellar.DecoratedSignature> Sign =
            new Method<Stellar.Transaction_ProtoWrapper.SignParam, Stellar.DecoratedSignature>(
                MethodType.Unary,
                ServiceName,
                "Sign",
                Transaction_ProtoWrapperSignParamGrpcMarshaller.Transaction_ProtoWrapper_SignParamMarshaller,
                DecoratedSignatureGrpcMarshaller.DecoratedSignatureMarshaller);

    }

    /// <summary>Custom marshallers for ITransaction_ProtoWrapper types</summary>
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
            if (!model.IsDefined(typeof(Stellar.Transaction_ProtoWrapper.SignParam)))
            {
                model.Add(typeof(Stellar.Transaction_ProtoWrapper.SignParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.DecoratedSignature)))
            {
                model.Add(typeof(Stellar.DecoratedSignature), true);
            }

        }

        /// <summary>Marshaller for CloneParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.CloneParam> Transaction_ProtoWrapper_CloneParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.CloneParam>(
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
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.IsSorobanParam> Transaction_ProtoWrapper_IsSorobanParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.IsSorobanParam>(
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

        /// <summary>Marshaller for SignParam</summary>
        public static readonly Marshaller<Stellar.Transaction_ProtoWrapper.SignParam> Transaction_ProtoWrapper_SignParamMarshaller = Marshallers.Create<Stellar.Transaction_ProtoWrapper.SignParam>(
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

    }

    /// <summary>gRPC service implementation for ITransaction_ProtoWrapper</summary>
    public class Transaction_ProtoWrapperGrpcService
    {
        private readonly ITransaction_ProtoWrapper _service;
        private readonly ILogger _logger;

        public Transaction_ProtoWrapperGrpcService(ITransaction_ProtoWrapper service, ILogger<Transaction_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for Clone method</summary>
        public async Task<Stellar.Transaction> Clone(Stellar.Transaction_ProtoWrapper.CloneParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Clone request");
                return _service.Clone(request) ;
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
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing IsSoroban request");
                return _service.IsSoroban(request) ;
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
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing IsSorobanInvocation request");
                return _service.IsSorobanInvocation(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in IsSorobanInvocation");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for Sign method</summary>
        public async Task<Stellar.DecoratedSignature> Sign(Stellar.Transaction_ProtoWrapper.SignParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing Sign request");
                return _service.Sign(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Sign");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
