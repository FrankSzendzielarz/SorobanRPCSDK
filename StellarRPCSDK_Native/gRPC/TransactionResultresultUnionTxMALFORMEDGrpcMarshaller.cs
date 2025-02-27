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
    /// <summary>Custom marshaller for Stellar.TransactionResult+resultUnion+TxMALFORMED</summary>
    public static class TransactionResultresultUnionTxMALFORMEDGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultresultUnionTxMALFORMEDGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult.resultUnion.TxMALFORMED
            if (!model.IsDefined(typeof(Stellar.TransactionResult.resultUnion.TxMALFORMED)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult.resultUnion.TxMALFORMED), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionResult+resultUnion+TxMALFORMED</summary>
        public static readonly Marshaller<Stellar.TransactionResult.resultUnion.TxMALFORMED> TransactionResult_resultUnion_TxMALFORMEDMarshaller = Marshallers.Create<Stellar.TransactionResult.resultUnion.TxMALFORMED>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult.resultUnion.TxMALFORMED>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
