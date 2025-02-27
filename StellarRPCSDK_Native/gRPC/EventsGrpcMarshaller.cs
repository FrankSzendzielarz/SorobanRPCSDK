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
    /// <summary>Custom marshaller for Stellar.RPC.Events</summary>
    public static class EventsGrpcMarshaller
    {
        // Static constructor to configure type
        static EventsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.Events
            if (!model.IsDefined(typeof(Stellar.RPC.Events)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.Events), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Type");
                metaType.Add(2, "Ledger");
                metaType.Add(3, "LedgerClosedAt");
                metaType.Add(4, "ContractId");
                metaType.Add(5, "Id");
                metaType.Add(6, "PagingToken");
                metaType.Add(7, "InSuccessfulContractCall");
                metaType.Add(8, "Topic");
                metaType.Add(9, "Value");
                metaType.Add(10, "TxHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.Events</summary>
        public static readonly Marshaller<Stellar.RPC.Events> EventsMarshaller = Marshallers.Create<Stellar.RPC.Events>(
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
                        return Serializer.Deserialize<Stellar.RPC.Events>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
