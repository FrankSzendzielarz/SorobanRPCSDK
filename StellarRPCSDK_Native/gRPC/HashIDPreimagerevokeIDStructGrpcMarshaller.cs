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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+revokeIDStruct</summary>
    public static class HashIDPreimagerevokeIDStructGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimagerevokeIDStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.revokeIDStruct
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.revokeIDStruct)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.revokeIDStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sourceAccount");
                metaType.Add(2, "seqNum");
                metaType.Add(3, "opNum");
                metaType.Add(4, "liquidityPoolID");
                metaType.Add(5, "asset");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HashIDPreimage+revokeIDStruct</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.revokeIDStruct> HashIDPreimage_revokeIDStructMarshaller = Marshallers.Create<Stellar.HashIDPreimage.revokeIDStruct>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.revokeIDStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
