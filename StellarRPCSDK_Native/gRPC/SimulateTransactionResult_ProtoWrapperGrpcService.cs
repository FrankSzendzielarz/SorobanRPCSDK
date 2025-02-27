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
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>gRPC service descriptor for ISimulateTransactionResult_ProtoWrapper</summary>
    public static class SimulateTransactionResult_ProtoWrapperGrpcDescriptor
    {
        public const string ServiceName = "Stellar.RPC.SimulateTransactionResult_ProtoWrapper";

        /// <summary>Method descriptor for ApplyTo</summary>
        public static readonly Method<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam, Stellar.Transaction> ApplyTo =
            new Method<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam, Stellar.Transaction>(
                MethodType.Unary,
                ServiceName,
                "ApplyTo",
                SimulateTransactionResult_ProtoWrapperApplyToParamGrpcMarshaller.SimulateTransactionResult_ProtoWrapper_ApplyToParamMarshaller,
                TransactionGrpcMarshaller.TransactionMarshaller);

    }

    /// <summary>Custom marshallers for ISimulateTransactionResult_ProtoWrapper types</summary>
    public static class SimulateTransactionResult_ProtoWrapperGrpcMarshaller
    {
        // Static constructor to configure types
        static SimulateTransactionResult_ProtoWrapperGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Ensure types are configured for AOT compatibility
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam)))
            {
                model.Add(typeof(Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam), true);
            }
            if (!model.IsDefined(typeof(Stellar.Transaction)))
            {
                model.Add(typeof(Stellar.Transaction), true);
            }

        }

        /// <summary>Marshaller for ApplyToParam</summary>
        public static readonly Marshaller<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam> SimulateTransactionResult_ProtoWrapper_ApplyToParamMarshaller = Marshallers.Create<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam>(
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
                        return Serializer.Deserialize<Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam>(ms);
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

    }

    /// <summary>gRPC service implementation for ISimulateTransactionResult_ProtoWrapper</summary>
    public class SimulateTransactionResult_ProtoWrapperGrpcService
    {
        private readonly ISimulateTransactionResult_ProtoWrapper _service;
        private readonly ILogger _logger;

        public SimulateTransactionResult_ProtoWrapperGrpcService(ISimulateTransactionResult_ProtoWrapper service, ILogger<SimulateTransactionResult_ProtoWrapperGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for ApplyTo method</summary>
        public async Task<Stellar.Transaction> ApplyTo(Stellar.RPC.SimulateTransactionResult_ProtoWrapper.ApplyToParam request, ServerCallContext context)
        {
            try
            {
                await Task.CompletedTask; // Preserve async context
                _logger.LogInformation("Processing ApplyTo request");
                return _service.ApplyTo(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in ApplyTo");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
