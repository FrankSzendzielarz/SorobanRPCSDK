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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeMap</summary>
    public static class SCSpecTypeDefScSpecTypeMapGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeMapGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeMap
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeMap)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeMap), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "map");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecTypeMap</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeMap> ScSpecTypeMapMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeMap>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeMap>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
