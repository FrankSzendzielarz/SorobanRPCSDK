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
    /// <summary>Custom marshaller for Stellar.TrustLineEntry+extUnion</summary>
    public static class TrustLineEntryextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineEntryextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineEntry.extUnion
            if (!model.IsDefined(typeof(Stellar.TrustLineEntry.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineEntry.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TrustLineEntry.extUnion.case_0));
                metaType.AddSubType(101, typeof(Stellar.TrustLineEntry.extUnion.case_1));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TrustLineEntry+extUnion</summary>
        public static readonly Marshaller<Stellar.TrustLineEntry.extUnion> TrustLineEntry_extUnionMarshaller = Marshallers.Create<Stellar.TrustLineEntry.extUnion>(
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
                        return Serializer.Deserialize<Stellar.TrustLineEntry.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
