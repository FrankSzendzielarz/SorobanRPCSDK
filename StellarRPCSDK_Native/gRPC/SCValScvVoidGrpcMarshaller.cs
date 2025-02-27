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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvVoid</summary>
    public static class SCValScvVoidGrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvVoidGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvVoid
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvVoid)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvVoid), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal+ScvVoid</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvVoid> SCVal_ScvVoidMarshaller = Marshallers.Create<Stellar.SCVal.ScvVoid>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvVoid>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
