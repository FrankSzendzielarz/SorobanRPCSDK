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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion+TxSUCCESS</summary>
    public static class TransactionResultresultUnionTxSUCCESSGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionTxSUCCESSGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion.TxSUCCESS
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion.TxSUCCESS)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion.TxSUCCESS), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "results");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionResult+resultUnion+TxSUCCESS</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion.TxSUCCESS> TransactionResult_resultUnion_TxSUCCESSMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion.TxSUCCESS>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion.TxSUCCESS>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
