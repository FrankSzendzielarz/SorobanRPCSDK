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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeBytes</summary>
    public static class SCSpecTypeDefScSpecTypeBytesGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeBytesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeBytes
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytes)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytes), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecTypeBytes</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeBytes> ScSpecTypeBytesMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeBytes>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeBytes>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
