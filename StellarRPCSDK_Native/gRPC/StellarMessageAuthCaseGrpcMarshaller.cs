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
    /// <summary>Custom marshaller for Stellar.StellarMessage+AuthCase</summary>
    public static class StellarMessageAuthCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageAuthCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.AuthCase
            if (!model.IsDefined(typeof(Stellar.StellarMessage.AuthCase)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.AuthCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "auth");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarMessage+AuthCase</summary>
        public static readonly Marshaller<Stellar.StellarMessage.AuthCase> StellarMessage_AuthCaseMarshaller = Marshallers.Create<Stellar.StellarMessage.AuthCase>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.AuthCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
