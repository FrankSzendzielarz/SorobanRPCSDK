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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion</summary>
    public static class InnerTransactionResultresultUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.InnerTransactionResult.resultUnion.TxSUCCESS));
                metaType.AddSubType(101, typeof(Stellar.InnerTransactionResult.resultUnion.TxFAILED));
                metaType.AddSubType(102, typeof(Stellar.InnerTransactionResult.resultUnion.TxtooEarly));
                metaType.AddSubType(103, typeof(Stellar.InnerTransactionResult.resultUnion.TxtooLate));
                metaType.AddSubType(104, typeof(Stellar.InnerTransactionResult.resultUnion.TxmissingOperation));
                metaType.AddSubType(105, typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSeq));
                metaType.AddSubType(106, typeof(Stellar.InnerTransactionResult.resultUnion.TxbadAuth));
                metaType.AddSubType(107, typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientBalance));
                metaType.AddSubType(108, typeof(Stellar.InnerTransactionResult.resultUnion.TxnoAccount));
                metaType.AddSubType(109, typeof(Stellar.InnerTransactionResult.resultUnion.TxinsufficientFee));
                metaType.AddSubType(110, typeof(Stellar.InnerTransactionResult.resultUnion.TxbadAuthExtra));
                metaType.AddSubType(111, typeof(Stellar.InnerTransactionResult.resultUnion.TxinternalError));
                metaType.AddSubType(112, typeof(Stellar.InnerTransactionResult.resultUnion.TxnotSupported));
                metaType.AddSubType(113, typeof(Stellar.InnerTransactionResult.resultUnion.TxbadSponsorship));
                metaType.AddSubType(114, typeof(Stellar.InnerTransactionResult.resultUnion.TxbadMinSeqAgeOrGap));
                metaType.AddSubType(115, typeof(Stellar.InnerTransactionResult.resultUnion.TxMALFORMED));
                metaType.AddSubType(116, typeof(Stellar.InnerTransactionResult.resultUnion.TxsorobanInvalid));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion> InnerTransactionResult_resultUnionMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
