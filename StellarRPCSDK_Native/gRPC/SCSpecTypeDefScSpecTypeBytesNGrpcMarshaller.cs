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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeBytesN</summary>
    public static class SCSpecTypeDefScSpecTypeBytesNGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeBytesNGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeBytesN
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytesN)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytesN), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(6, "bytesN");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecTypeDef+ScSpecTypeBytesN</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeBytesN> SCSpecTypeDef_ScSpecTypeBytesNMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeBytesN>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeBytesN>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
