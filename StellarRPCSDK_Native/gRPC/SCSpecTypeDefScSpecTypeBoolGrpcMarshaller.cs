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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeBool</summary>
    public static class SCSpecTypeDefScSpecTypeBoolGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeBoolGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeBool
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBool)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeBool), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecTypeBool</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeBool> ScSpecTypeBoolMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeBool>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeBool>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
