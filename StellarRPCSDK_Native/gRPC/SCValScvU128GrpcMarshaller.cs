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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvU128</summary>
    public static class SCValScvU128GrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvU128GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvU128
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvU128)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvU128), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(9, "u128");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScvU128</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvU128> ScvU128Marshaller = Marshallers.Create<Stellar.SCVal.ScvU128>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvU128>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
