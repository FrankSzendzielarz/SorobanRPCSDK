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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion</summary>
    public static class TransactionResultresultUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TransactionResult.resultUnion.TxfeeBumpInnerSuccess));
                metaType.AddSubType(101, typeof(Stellar.TransactionResult.resultUnion.TxfeeBumpInnerFailed));
                metaType.AddSubType(102, typeof(Stellar.TransactionResult.resultUnion.TxSUCCESS));
                metaType.AddSubType(103, typeof(Stellar.TransactionResult.resultUnion.TxFAILED));
                metaType.AddSubType(104, typeof(Stellar.TransactionResult.resultUnion.TxtooEarly));
                metaType.AddSubType(105, typeof(Stellar.TransactionResult.resultUnion.TxtooLate));
                metaType.AddSubType(106, typeof(Stellar.TransactionResult.resultUnion.TxmissingOperation));
                metaType.AddSubType(107, typeof(Stellar.TransactionResult.resultUnion.TxbadSeq));
                metaType.AddSubType(108, typeof(Stellar.TransactionResult.resultUnion.TxbadAuth));
                metaType.AddSubType(109, typeof(Stellar.TransactionResult.resultUnion.TxinsufficientBalance));
                metaType.AddSubType(110, typeof(Stellar.TransactionResult.resultUnion.TxnoAccount));
                metaType.AddSubType(111, typeof(Stellar.TransactionResult.resultUnion.TxinsufficientFee));
                metaType.AddSubType(112, typeof(Stellar.TransactionResult.resultUnion.TxbadAuthExtra));
                metaType.AddSubType(113, typeof(Stellar.TransactionResult.resultUnion.TxinternalError));
                metaType.AddSubType(114, typeof(Stellar.TransactionResult.resultUnion.TxnotSupported));
                metaType.AddSubType(115, typeof(Stellar.TransactionResult.resultUnion.TxbadSponsorship));
                metaType.AddSubType(116, typeof(Stellar.TransactionResult.resultUnion.TxbadMinSeqAgeOrGap));
                metaType.AddSubType(117, typeof(Stellar.TransactionResult.resultUnion.TxMALFORMED));
                metaType.AddSubType(118, typeof(Stellar.TransactionResult.resultUnion.TxsorobanInvalid));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionResult+resultUnion</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion> TransactionResult_resultUnionMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
