// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.SimulateTransactionParams</summary>
    public static class SimulateTransactionParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static SimulateTransactionParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.SimulateTransactionParams
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionParams)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.SimulateTransactionParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Transaction");
                metaType.Add(2, "ResourceConfig");
                metaType.UseConstructor = false;
            }
        }

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

    }
}
