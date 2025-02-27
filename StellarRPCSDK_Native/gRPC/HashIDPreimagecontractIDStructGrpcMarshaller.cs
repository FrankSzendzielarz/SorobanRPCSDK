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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+contractIDStruct</summary>
    public static class HashIDPreimagecontractIDStructGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimagecontractIDStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.contractIDStruct
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.contractIDStruct)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.contractIDStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "networkID");
                metaType.Add(2, "contractIDPreimage");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HashIDPreimage+contractIDStruct</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.contractIDStruct> HashIDPreimage_contractIDStructMarshaller = Marshallers.Create<Stellar.HashIDPreimage.contractIDStruct>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.contractIDStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
