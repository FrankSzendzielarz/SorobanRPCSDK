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
    /// <summary>Custom marshaller for Stellar.FeeBumpTransaction+innerTxUnion+EnvelopeTypeTx</summary>
    public static class FeeBumpTransactioninnerTxUnionEnvelopeTypeTxGrpcMarshaller
    {
        // Static constructor to configure type
        static FeeBumpTransactioninnerTxUnionEnvelopeTypeTxGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx
            if (!model.IsDefined(typeof(Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx)))
            {
                var metaType = model.Add(typeof(Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "v1");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.FeeBumpTransaction+innerTxUnion+EnvelopeTypeTx</summary>
        public static readonly Marshaller<Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx> FeeBumpTransaction_innerTxUnion_EnvelopeTypeTxMarshaller = Marshallers.Create<Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx>(
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
                        return Serializer.Deserialize<Stellar.FeeBumpTransaction.innerTxUnion.EnvelopeTypeTx>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
