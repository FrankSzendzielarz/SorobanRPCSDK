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
    /// <summary>Custom marshaller for Stellar.PreconditionsV2</summary>
    public static class PreconditionsV2GrpcMarshaller
    {
        // Static constructor to configure type
        static PreconditionsV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PreconditionsV2
            if (!model.IsDefined(typeof(Stellar.PreconditionsV2)))
            {
                var metaType = model.Add(typeof(Stellar.PreconditionsV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "timeBounds");
                metaType.Add(2, "ledgerBounds");
                metaType.Add(3, "minSeqNum");
                metaType.Add(4, "minSeqAge");
                metaType.Add(5, "minSeqLedgerGap");
                metaType.Add(6, "extraSigners");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PreconditionsV2</summary>
        public static readonly Marshaller<Stellar.PreconditionsV2> PreconditionsV2Marshaller = Marshallers.Create<Stellar.PreconditionsV2>(
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
                        return Serializer.Deserialize<Stellar.PreconditionsV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
