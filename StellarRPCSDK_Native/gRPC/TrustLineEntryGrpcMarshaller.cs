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
    /// <summary>Custom marshaller for Stellar.TrustLineEntry</summary>
    public static class TrustLineEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineEntry
            if (!model.IsDefined(typeof(Stellar.TrustLineEntry)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "accountID");
                metaType.Add(2, "asset");
                metaType.Add(3, "balance");
                metaType.Add(4, "limit");
                metaType.Add(5, "flags");
                metaType.Add(6, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TrustLineEntry</summary>
        public static readonly Marshaller<Stellar.TrustLineEntry> TrustLineEntryMarshaller = Marshallers.Create<Stellar.TrustLineEntry>(
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
                        return Serializer.Deserialize<Stellar.TrustLineEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
