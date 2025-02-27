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
    /// <summary>Custom marshaller for Stellar.StellarMessage+GeneralizedTxSet</summary>
    public static class StellarMessageGeneralizedTxSetGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageGeneralizedTxSetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.GeneralizedTxSet
            if (!model.IsDefined(typeof(Stellar.StellarMessage.GeneralizedTxSet)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.GeneralizedTxSet), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(8, "generalizedTxSet");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GeneralizedTxSet</summary>
        public static readonly Marshaller<Stellar.StellarMessage.GeneralizedTxSet> GeneralizedTxSetMarshaller = Marshallers.Create<Stellar.StellarMessage.GeneralizedTxSet>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.GeneralizedTxSet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
