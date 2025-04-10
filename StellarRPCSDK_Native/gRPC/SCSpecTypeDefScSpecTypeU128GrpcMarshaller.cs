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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeU128</summary>
    public static class SCSpecTypeDefScSpecTypeU128GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeU128GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeU128
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeU128)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeU128), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecTypeDef+ScSpecTypeU128</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeU128> SCSpecTypeDef_ScSpecTypeU128Marshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeU128>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeU128>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
