// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.LedgerHeader</summary>
    public static class LedgerHeaderGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerHeaderGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerHeader
            if (!model.IsDefined(typeof(Stellar.LedgerHeader)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerHeader), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerVersion");
                metaType.Add(2, "previousLedgerHash");
                metaType.Add(3, "scpValue");
                metaType.Add(4, "txSetResultHash");
                metaType.Add(5, "bucketListHash");
                metaType.Add(6, "ledgerSeq");
                metaType.Add(7, "totalCoins");
                metaType.Add(8, "feePool");
                metaType.Add(9, "inflationSeq");
                metaType.Add(10, "idPool");
                metaType.Add(11, "baseFee");
                metaType.Add(12, "baseReserve");
                metaType.Add(13, "maxTxSetSize");
                metaType.Add(14, "skipList");
                metaType.Add(15, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LedgerHeader</summary>
        public static readonly Marshaller<Stellar.LedgerHeader> LedgerHeaderMarshaller = Marshallers.Create<Stellar.LedgerHeader>(
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
                        return Serializer.Deserialize<Stellar.LedgerHeader>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
