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
    /// <summary>Custom marshaller for Stellar.LedgerCloseMetaV0</summary>
    public static class LedgerCloseMetaV0GrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerCloseMetaV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerCloseMetaV0
            if (!model.IsDefined(typeof(Stellar.LedgerCloseMetaV0)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerCloseMetaV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerHeader");
                metaType.Add(2, "txSet");
                metaType.Add(3, "txProcessing");
                metaType.Add(4, "upgradesProcessing");
                metaType.Add(5, "scpInfo");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerCloseMetaV0</summary>
        public static readonly Marshaller<Stellar.LedgerCloseMetaV0> LedgerCloseMetaV0Marshaller = Marshallers.Create<Stellar.LedgerCloseMetaV0>(
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
                        return Serializer.Deserialize<Stellar.LedgerCloseMetaV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
