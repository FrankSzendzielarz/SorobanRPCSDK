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
    /// <summary>gRPC service descriptor for StellarRPCClient</summary>
    public static class StellarRPCClientGrpcDescriptor
    {
        public const string ServiceName = "Stellar.RPC.StellarRPCClient";

        /// <summary>Method descriptor for GetEventsAsync</summary>
        public static readonly Method<Stellar.RPC.GetEventsParams, Stellar.RPC.GetEventsResult> GetEventsAsyncMethod =
            new Method<Stellar.RPC.GetEventsParams, Stellar.RPC.GetEventsResult>(
                MethodType.Unary,
                ServiceName,
                "GetEventsAsync",
                GetEventsParamsGrpcMarshaller.GetEventsParamsMarshaller,
                GetEventsResultGrpcMarshaller.GetEventsResultMarshaller);

        /// <summary>Method descriptor for GetLedgerEntriesAsync</summary>
        public static readonly Method<Stellar.RPC.GetLedgerEntriesParams, Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesAsyncMethod =
            new Method<Stellar.RPC.GetLedgerEntriesParams, Stellar.RPC.GetLedgerEntriesResult>(
                MethodType.Unary,
                ServiceName,
                "GetLedgerEntriesAsync",
                GetLedgerEntriesParamsGrpcMarshaller.GetLedgerEntriesParamsMarshaller,
                GetLedgerEntriesResultGrpcMarshaller.GetLedgerEntriesResultMarshaller);

        /// <summary>Method descriptor for GetTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.GetTransactionParams, Stellar.RPC.GetTransactionResult> GetTransactionAsyncMethod =
            new Method<Stellar.RPC.GetTransactionParams, Stellar.RPC.GetTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "GetTransactionAsync",
                GetTransactionParamsGrpcMarshaller.GetTransactionParamsMarshaller,
                GetTransactionResultGrpcMarshaller.GetTransactionResultMarshaller);

        /// <summary>Method descriptor for GetTransactionsAsync</summary>
        public static readonly Method<Stellar.RPC.GetTransactionsParams, Stellar.RPC.GetTransactionsResult> GetTransactionsAsyncMethod =
            new Method<Stellar.RPC.GetTransactionsParams, Stellar.RPC.GetTransactionsResult>(
                MethodType.Unary,
                ServiceName,
                "GetTransactionsAsync",
                GetTransactionsParamsGrpcMarshaller.GetTransactionsParamsMarshaller,
                GetTransactionsResultGrpcMarshaller.GetTransactionsResultMarshaller);

        /// <summary>Method descriptor for SendTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.SendTransactionParams, Stellar.RPC.SendTransactionResult> SendTransactionAsyncMethod =
            new Method<Stellar.RPC.SendTransactionParams, Stellar.RPC.SendTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "SendTransactionAsync",
                SendTransactionParamsGrpcMarshaller.SendTransactionParamsMarshaller,
                SendTransactionResultGrpcMarshaller.SendTransactionResultMarshaller);

        /// <summary>Method descriptor for SimulateTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.SimulateTransactionParams, Stellar.RPC.SimulateTransactionResult> SimulateTransactionAsyncMethod =
            new Method<Stellar.RPC.SimulateTransactionParams, Stellar.RPC.SimulateTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "SimulateTransactionAsync",
                SimulateTransactionParamsGrpcMarshaller.SimulateTransactionParamsMarshaller,
                SimulateTransactionResultGrpcMarshaller.SimulateTransactionResultMarshaller);

    }

    /// <summary>Custom marshallers for StellarRPCClient types</summary>
    public static class StellarRPCClientGrpcMarshaller
    {
        // Static constructor to configure types
        static StellarRPCClientGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model
            var model = RuntimeTypeModel.Default;

            // Ensure types are configured for AOT compatibility
            if (!model.IsDefined(typeof(Stellar.RPC.GetEventsParams)))
            {
                model.Add(typeof(Stellar.RPC.GetEventsParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetEventsResult)))
            {
                model.Add(typeof(Stellar.RPC.GetEventsResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetLedgerEntriesParams)))
            {
                model.Add(typeof(Stellar.RPC.GetLedgerEntriesParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetLedgerEntriesResult)))
            {
                model.Add(typeof(Stellar.RPC.GetLedgerEntriesResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionParams)))
            {
                model.Add(typeof(Stellar.RPC.GetTransactionParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionResult)))
            {
                model.Add(typeof(Stellar.RPC.GetTransactionResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionsParams)))
            {
                model.Add(typeof(Stellar.RPC.GetTransactionsParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionsResult)))
            {
                model.Add(typeof(Stellar.RPC.GetTransactionsResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.SendTransactionParams)))
            {
                model.Add(typeof(Stellar.RPC.SendTransactionParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.SendTransactionResult)))
            {
                model.Add(typeof(Stellar.RPC.SendTransactionResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionParams)))
            {
                model.Add(typeof(Stellar.RPC.SimulateTransactionParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionResult)))
            {
                model.Add(typeof(Stellar.RPC.SimulateTransactionResult), true);
            }


        }

        /// <summary>Marshaller for GetEventsParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetEventsParams> GetEventsParamsMarshaller = Marshallers.Create<Stellar.RPC.GetEventsParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetEventsParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetEventsResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetEventsResult> GetEventsResultMarshaller = Marshallers.Create<Stellar.RPC.GetEventsResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetEventsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetLedgerEntriesParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetLedgerEntriesParams> GetLedgerEntriesParamsMarshaller = Marshallers.Create<Stellar.RPC.GetLedgerEntriesParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetLedgerEntriesParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetLedgerEntriesResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesResultMarshaller = Marshallers.Create<Stellar.RPC.GetLedgerEntriesResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetLedgerEntriesResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetTransactionParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionParams> GetTransactionParamsMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetTransactionResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionResult> GetTransactionResultMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetTransactionsParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionsParams> GetTransactionsParamsMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionsParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionsParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetTransactionsResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionsResult> GetTransactionsResultMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionsResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SendTransactionParams</summary>
        public static readonly Marshaller<Stellar.RPC.SendTransactionParams> SendTransactionParamsMarshaller = Marshallers.Create<Stellar.RPC.SendTransactionParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.SendTransactionParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SendTransactionResult</summary>
        public static readonly Marshaller<Stellar.RPC.SendTransactionResult> SendTransactionResultMarshaller = Marshallers.Create<Stellar.RPC.SendTransactionResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.SendTransactionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SimulateTransactionParams</summary>
        public static readonly Marshaller<Stellar.RPC.SimulateTransactionParams> SimulateTransactionParamsMarshaller = Marshallers.Create<Stellar.RPC.SimulateTransactionParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.SimulateTransactionParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for SimulateTransactionResult</summary>
        public static readonly Marshaller<Stellar.RPC.SimulateTransactionResult> SimulateTransactionResultMarshaller = Marshallers.Create<Stellar.RPC.SimulateTransactionResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.SimulateTransactionResult>(ms);
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

    /// <summary>gRPC service implementation for StellarRPCClient</summary>
    public class StellarRPCClientGrpcService
    {
        private readonly StellarRPCClient _service;
        private readonly ILogger _logger;

        public StellarRPCClientGrpcService(StellarRPCClient service, ILogger<StellarRPCClientGrpcService> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>Handler for GetEventsAsync method</summary>
        public async Task<Stellar.RPC.GetEventsResult> GetEventsAsync(Stellar.RPC.GetEventsParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetEventsAsync request");
                return await _service.GetEventsAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetEventsAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetLedgerEntriesAsync method</summary>
        public async Task<Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesAsync(Stellar.RPC.GetLedgerEntriesParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetLedgerEntriesAsync request");
                return await _service.GetLedgerEntriesAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetLedgerEntriesAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetTransactionAsync method</summary>
        public async Task<Stellar.RPC.GetTransactionResult> GetTransactionAsync(Stellar.RPC.GetTransactionParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetTransactionAsync request");
                return await _service.GetTransactionAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetTransactionAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetTransactionsAsync method</summary>
        public async Task<Stellar.RPC.GetTransactionsResult> GetTransactionsAsync(Stellar.RPC.GetTransactionsParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetTransactionsAsync request");
                return await _service.GetTransactionsAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetTransactionsAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for SendTransactionAsync method</summary>
        public async Task<Stellar.RPC.SendTransactionResult> SendTransactionAsync(Stellar.RPC.SendTransactionParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing SendTransactionAsync request");
                return await _service.SendTransactionAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in SendTransactionAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for SimulateTransactionAsync method</summary>
        public async Task<Stellar.RPC.SimulateTransactionResult> SimulateTransactionAsync(Stellar.RPC.SimulateTransactionParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing SimulateTransactionAsync request");
                return await _service.SimulateTransactionAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in SimulateTransactionAsync");
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
