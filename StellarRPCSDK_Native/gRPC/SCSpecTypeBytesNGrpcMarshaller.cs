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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeBytesN</summary>
    public static class SCSpecTypeBytesNGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeBytesNGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeBytesN
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeBytesN)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeBytesN), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "n");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeBytesN</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeBytesN> SCSpecTypeBytesNMarshaller = Marshallers.Create<Stellar.SCSpecTypeBytesN>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeBytesN>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
