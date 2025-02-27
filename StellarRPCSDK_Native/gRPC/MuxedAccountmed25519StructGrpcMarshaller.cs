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
    /// <summary>Custom marshaller for Stellar.MuxedAccount+med25519Struct</summary>
    public static class MuxedAccountmed25519StructGrpcMarshaller
    {
        // Static constructor to configure type
        static MuxedAccountmed25519StructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.MuxedAccount.med25519Struct
            if (!model.IsDefined(typeof(Stellar.MuxedAccount.med25519Struct)))
            {
                var metaType = model.Add(typeof(Stellar.MuxedAccount.med25519Struct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "id");
                metaType.Add(2, "ed25519");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for med25519Struct</summary>
        public static readonly Marshaller<Stellar.MuxedAccount.med25519Struct> med25519StructMarshaller = Marshallers.Create<Stellar.MuxedAccount.med25519Struct>(
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
                        return Serializer.Deserialize<Stellar.MuxedAccount.med25519Struct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
