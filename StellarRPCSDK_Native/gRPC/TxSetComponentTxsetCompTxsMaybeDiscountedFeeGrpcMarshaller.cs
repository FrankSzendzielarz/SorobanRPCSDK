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
    /// <summary>Custom marshaller for Stellar.TxSetComponent+TxsetCompTxsMaybeDiscountedFee</summary>
    public static class TxSetComponentTxsetCompTxsMaybeDiscountedFeeGrpcMarshaller
    {
        // Static constructor to configure type
        static TxSetComponentTxsetCompTxsMaybeDiscountedFeeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee
            if (!model.IsDefined(typeof(Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee)))
            {
                var metaType = model.Add(typeof(Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txsMaybeDiscountedFee");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TxSetComponent+TxsetCompTxsMaybeDiscountedFee</summary>
        public static readonly Marshaller<Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee> TxSetComponent_TxsetCompTxsMaybeDiscountedFeeMarshaller = Marshallers.Create<Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee>(
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
                        return Serializer.Deserialize<Stellar.TxSetComponent.TxsetCompTxsMaybeDiscountedFee>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
