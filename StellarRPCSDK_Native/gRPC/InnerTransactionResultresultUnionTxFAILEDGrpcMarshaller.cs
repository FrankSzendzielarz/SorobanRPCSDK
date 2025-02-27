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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxFAILED</summary>
    public static class InnerTransactionResultresultUnionTxFAILEDGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxFAILEDGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxFAILED
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxFAILED)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxFAILED), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "results");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxFAILED</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxFAILED> InnerTransactionResult_resultUnion_TxFAILEDMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxFAILED>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxFAILED>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
