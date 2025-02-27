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
    /// <summary>Custom marshaller for Stellar.SCError+SceObject</summary>
    public static class SCErrorSceObjectGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceObjectGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceObject
            if (!model.IsDefined(typeof(Stellar.SCError.SceObject)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceObject), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SceObject</summary>
        public static readonly Marshaller<Stellar.SCError.SceObject> SceObjectMarshaller = Marshallers.Create<Stellar.SCError.SceObject>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceObject>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
