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
    /// <summary>Custom marshaller for Stellar.SCError+SceStorage</summary>
    public static class SCErrorSceStorageGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceStorageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceStorage
            if (!model.IsDefined(typeof(Stellar.SCError.SceStorage)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceStorage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCError+SceStorage</summary>
        public static readonly Marshaller<Stellar.SCError.SceStorage> SCError_SceStorageMarshaller = Marshallers.Create<Stellar.SCError.SceStorage>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceStorage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
