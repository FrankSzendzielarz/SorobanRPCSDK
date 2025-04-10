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
    /// <summary>gRPC service descriptor for IStellarRPCClient</summary>
    public static class StellarRPCClientGrpcDescriptor
    {
        public const string ServiceName = "Stellar.RPC.StellarRPCClient";

        /// <summary>Method descriptor for GetEventsAsync</summary>
        public static readonly Method<Stellar.RPC.GetEventsParams, Stellar.RPC.GetEventsResult> GetEventsAsync =
            new Method<Stellar.RPC.GetEventsParams, Stellar.RPC.GetEventsResult>(
                MethodType.Unary,
                ServiceName,
                "GetEventsAsync",
                GetEventsParamsGrpcMarshaller.GetEventsParamsMarshaller,
                GetEventsResultGrpcMarshaller.GetEventsResultMarshaller);

        /// <summary>Method descriptor for GetFeeStatsAsync</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetFeeStatsResult> GetFeeStatsAsync =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetFeeStatsResult>(
                MethodType.Unary,
                ServiceName,
                "GetFeeStatsAsync",
                EmptyGrpcMarshaller.EmptyMarshaller,
                GetFeeStatsResultGrpcMarshaller.GetFeeStatsResultMarshaller);

        /// <summary>Method descriptor for GetHealthAsync</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetHealthResult> GetHealthAsync =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetHealthResult>(
                MethodType.Unary,
                ServiceName,
                "GetHealthAsync",
                EmptyGrpcMarshaller.EmptyMarshaller,
                GetHealthResultGrpcMarshaller.GetHealthResultMarshaller);

        /// <summary>Method descriptor for GetLatestLedgerAsync</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetLatestLedgerResult> GetLatestLedgerAsync =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetLatestLedgerResult>(
                MethodType.Unary,
                ServiceName,
                "GetLatestLedgerAsync",
                EmptyGrpcMarshaller.EmptyMarshaller,
                GetLatestLedgerResultGrpcMarshaller.GetLatestLedgerResultMarshaller);

        /// <summary>Method descriptor for GetLedgerEntriesAsync</summary>
        public static readonly Method<Stellar.RPC.GetLedgerEntriesParams, Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesAsync =
            new Method<Stellar.RPC.GetLedgerEntriesParams, Stellar.RPC.GetLedgerEntriesResult>(
                MethodType.Unary,
                ServiceName,
                "GetLedgerEntriesAsync",
                GetLedgerEntriesParamsGrpcMarshaller.GetLedgerEntriesParamsMarshaller,
                GetLedgerEntriesResultGrpcMarshaller.GetLedgerEntriesResultMarshaller);

        /// <summary>Method descriptor for GetNetworkAsync</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetNetworkResult> GetNetworkAsync =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetNetworkResult>(
                MethodType.Unary,
                ServiceName,
                "GetNetworkAsync",
                EmptyGrpcMarshaller.EmptyMarshaller,
                GetNetworkResultGrpcMarshaller.GetNetworkResultMarshaller);

        /// <summary>Method descriptor for GetTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.GetTransactionParams, Stellar.RPC.GetTransactionResult> GetTransactionAsync =
            new Method<Stellar.RPC.GetTransactionParams, Stellar.RPC.GetTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "GetTransactionAsync",
                GetTransactionParamsGrpcMarshaller.GetTransactionParamsMarshaller,
                GetTransactionResultGrpcMarshaller.GetTransactionResultMarshaller);

        /// <summary>Method descriptor for GetTransactionsAsync</summary>
        public static readonly Method<Stellar.RPC.GetTransactionsParams, Stellar.RPC.GetTransactionsResult> GetTransactionsAsync =
            new Method<Stellar.RPC.GetTransactionsParams, Stellar.RPC.GetTransactionsResult>(
                MethodType.Unary,
                ServiceName,
                "GetTransactionsAsync",
                GetTransactionsParamsGrpcMarshaller.GetTransactionsParamsMarshaller,
                GetTransactionsResultGrpcMarshaller.GetTransactionsResultMarshaller);

        /// <summary>Method descriptor for GetVersionInfoAsync</summary>
        public static readonly Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetVersionInfoResult> GetVersionInfoAsync =
            new Method<Google.Protobuf.WellKnownTypes.Empty, Stellar.RPC.GetVersionInfoResult>(
                MethodType.Unary,
                ServiceName,
                "GetVersionInfoAsync",
                EmptyGrpcMarshaller.EmptyMarshaller,
                GetVersionInfoResultGrpcMarshaller.GetVersionInfoResultMarshaller);

        /// <summary>Method descriptor for SendTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.SendTransactionParams, Stellar.RPC.SendTransactionResult> SendTransactionAsync =
            new Method<Stellar.RPC.SendTransactionParams, Stellar.RPC.SendTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "SendTransactionAsync",
                SendTransactionParamsGrpcMarshaller.SendTransactionParamsMarshaller,
                SendTransactionResultGrpcMarshaller.SendTransactionResultMarshaller);

        /// <summary>Method descriptor for SimulateTransactionAsync</summary>
        public static readonly Method<Stellar.RPC.SimulateTransactionParams, Stellar.RPC.SimulateTransactionResult> SimulateTransactionAsync =
            new Method<Stellar.RPC.SimulateTransactionParams, Stellar.RPC.SimulateTransactionResult>(
                MethodType.Unary,
                ServiceName,
                "SimulateTransactionAsync",
                SimulateTransactionParamsGrpcMarshaller.SimulateTransactionParamsMarshaller,
                SimulateTransactionResultGrpcMarshaller.SimulateTransactionResultMarshaller);

    }

    /// <summary>Custom marshallers for IStellarRPCClient types</summary>
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
            if (!model.IsDefined(typeof(Stellar.RPC.GetFeeStatsResult)))
            {
                model.Add(typeof(Stellar.RPC.GetFeeStatsResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetHealthResult)))
            {
                model.Add(typeof(Stellar.RPC.GetHealthResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetLatestLedgerResult)))
            {
                model.Add(typeof(Stellar.RPC.GetLatestLedgerResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetLedgerEntriesParams)))
            {
                model.Add(typeof(Stellar.RPC.GetLedgerEntriesParams), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetLedgerEntriesResult)))
            {
                model.Add(typeof(Stellar.RPC.GetLedgerEntriesResult), true);
            }
            if (!model.IsDefined(typeof(Stellar.RPC.GetNetworkResult)))
            {
                model.Add(typeof(Stellar.RPC.GetNetworkResult), true);
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
            if (!model.IsDefined(typeof(Stellar.RPC.GetVersionInfoResult)))
            {
                model.Add(typeof(Stellar.RPC.GetVersionInfoResult), true);
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

        /// <summary>Marshaller for GetFeeStatsResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetFeeStatsResult> GetFeeStatsResultMarshaller = Marshallers.Create<Stellar.RPC.GetFeeStatsResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetFeeStatsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetHealthResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetHealthResult> GetHealthResultMarshaller = Marshallers.Create<Stellar.RPC.GetHealthResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetHealthResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

        /// <summary>Marshaller for GetLatestLedgerResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetLatestLedgerResult> GetLatestLedgerResultMarshaller = Marshallers.Create<Stellar.RPC.GetLatestLedgerResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetLatestLedgerResult>(ms);
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

        /// <summary>Marshaller for GetNetworkResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetNetworkResult> GetNetworkResultMarshaller = Marshallers.Create<Stellar.RPC.GetNetworkResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetNetworkResult>(ms);
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

        /// <summary>Marshaller for GetVersionInfoResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetVersionInfoResult> GetVersionInfoResultMarshaller = Marshallers.Create<Stellar.RPC.GetVersionInfoResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetVersionInfoResult>(ms);
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

    }

    /// <summary>gRPC service implementation for IStellarRPCClient</summary>
    public class StellarRPCClientGrpcService
    {
        private readonly IStellarRPCClient _service;
        private readonly ILogger _logger;

        public StellarRPCClientGrpcService(IStellarRPCClient service, ILogger<StellarRPCClientGrpcService> logger)
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
                return await _service.GetEventsAsync(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetEventsAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetFeeStatsAsync method</summary>
        public async Task<Stellar.RPC.GetFeeStatsResult> GetFeeStatsAsync(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetFeeStatsAsync request");
                return await _service.GetFeeStatsAsync() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetFeeStatsAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetHealthAsync method</summary>
        public async Task<Stellar.RPC.GetHealthResult> GetHealthAsync(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetHealthAsync request");
                return await _service.GetHealthAsync() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetHealthAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetLatestLedgerAsync method</summary>
        public async Task<Stellar.RPC.GetLatestLedgerResult> GetLatestLedgerAsync(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetLatestLedgerAsync request");
                return await _service.GetLatestLedgerAsync() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetLatestLedgerAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetLedgerEntriesAsync method</summary>
        public async Task<Stellar.RPC.GetLedgerEntriesResult> GetLedgerEntriesAsync(Stellar.RPC.GetLedgerEntriesParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetLedgerEntriesAsync request");
                return await _service.GetLedgerEntriesAsync(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetLedgerEntriesAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetNetworkAsync method</summary>
        public async Task<Stellar.RPC.GetNetworkResult> GetNetworkAsync(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetNetworkAsync request");
                return await _service.GetNetworkAsync() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetNetworkAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetTransactionAsync method</summary>
        public async Task<Stellar.RPC.GetTransactionResult> GetTransactionAsync(Stellar.RPC.GetTransactionParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetTransactionAsync request");
                return await _service.GetTransactionAsync(request) ;
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
                return await _service.GetTransactionsAsync(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetTransactionsAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for GetVersionInfoAsync method</summary>
        public async Task<Stellar.RPC.GetVersionInfoResult> GetVersionInfoAsync(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing GetVersionInfoAsync request");
                return await _service.GetVersionInfoAsync() ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetVersionInfoAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        /// <summary>Handler for SendTransactionAsync method</summary>
        public async Task<Stellar.RPC.SendTransactionResult> SendTransactionAsync(Stellar.RPC.SendTransactionParams request, ServerCallContext context)
        {
            try
            {
                _logger.LogInformation("Processing SendTransactionAsync request");
                return await _service.SendTransactionAsync(request) ;
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
                return await _service.SimulateTransactionAsync(request) ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in SimulateTransactionAsync");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

    }
}
