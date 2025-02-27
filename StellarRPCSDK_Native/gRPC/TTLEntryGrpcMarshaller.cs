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
    /// <summary>Custom marshaller for Stellar.TTLEntry</summary>
    public static class TTLEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static TTLEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TTLEntry
            if (!model.IsDefined(typeof(Stellar.TTLEntry)))
            {
                var metaType = model.Add(typeof(Stellar.TTLEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "keyHash");
                metaType.Add(2, "liveUntilLedgerSeq");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TTLEntry</summary>
        public static readonly Marshaller<Stellar.TTLEntry> TTLEntryMarshaller = Marshallers.Create<Stellar.TTLEntry>(
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
                        return Serializer.Deserialize<Stellar.TTLEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
