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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeTuple</summary>
    public static class SCSpecTypeDefScSpecTypeTupleGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeTupleGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeTuple
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeTuple)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeTuple), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "tuple");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecTypeTuple</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeTuple> ScSpecTypeTupleMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeTuple>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeTuple>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
