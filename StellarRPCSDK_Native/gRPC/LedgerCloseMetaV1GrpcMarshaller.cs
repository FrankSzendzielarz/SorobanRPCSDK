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
    /// <summary>Custom marshaller for Stellar.LedgerCloseMetaV1</summary>
    public static class LedgerCloseMetaV1GrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerCloseMetaV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerCloseMetaV1
            if (!model.IsDefined(typeof(Stellar.LedgerCloseMetaV1)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerCloseMetaV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "ledgerHeader");
                metaType.Add(3, "txSet");
                metaType.Add(4, "txProcessing");
                metaType.Add(5, "upgradesProcessing");
                metaType.Add(6, "scpInfo");
                metaType.Add(7, "totalByteSizeOfBucketList");
                metaType.Add(8, "evictedTemporaryLedgerKeys");
                metaType.Add(9, "evictedPersistentLedgerEntries");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerCloseMetaV1</summary>
        public static readonly Marshaller<Stellar.LedgerCloseMetaV1> LedgerCloseMetaV1Marshaller = Marshallers.Create<Stellar.LedgerCloseMetaV1>(
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
                        return Serializer.Deserialize<Stellar.LedgerCloseMetaV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
