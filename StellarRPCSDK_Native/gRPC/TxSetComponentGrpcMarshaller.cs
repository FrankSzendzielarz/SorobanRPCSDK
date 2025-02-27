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
    /// <summary>Custom marshaller for Stellar.TxSetComponent</summary>
    public static class TxSetComponentGrpcMarshaller
    {
        // Static constructor to configure type
        static TxSetComponentGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TxSetComponent
            if (!model.IsDefined(typeof(Stellar.TxSetComponent)))
            {
                var metaType = model.Add(typeof(Stellar.TxSetComponent), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TxSetComponent</summary>
        public static readonly Marshaller<Stellar.TxSetComponent> TxSetComponentMarshaller = Marshallers.Create<Stellar.TxSetComponent>(
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
                        return Serializer.Deserialize<Stellar.TxSetComponent>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
