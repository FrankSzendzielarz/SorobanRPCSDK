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
    /// <summary>Custom marshaller for Stellar.MuxedAccount+KeyTypeMuxedEd25519</summary>
    public static class MuxedAccountKeyTypeMuxedEd25519GrpcMarshaller
    {
        // Static constructor to configure type
        static MuxedAccountKeyTypeMuxedEd25519GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.MuxedAccount.KeyTypeMuxedEd25519
            if (!model.IsDefined(typeof(Stellar.MuxedAccount.KeyTypeMuxedEd25519)))
            {
                var metaType = model.Add(typeof(Stellar.MuxedAccount.KeyTypeMuxedEd25519), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "med25519");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for KeyTypeMuxedEd25519</summary>
        public static readonly Marshaller<Stellar.MuxedAccount.KeyTypeMuxedEd25519> KeyTypeMuxedEd25519Marshaller = Marshallers.Create<Stellar.MuxedAccount.KeyTypeMuxedEd25519>(
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
                        return Serializer.Deserialize<Stellar.MuxedAccount.KeyTypeMuxedEd25519>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
