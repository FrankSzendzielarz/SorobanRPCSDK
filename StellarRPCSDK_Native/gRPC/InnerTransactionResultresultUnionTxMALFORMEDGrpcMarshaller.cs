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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxMALFORMED</summary>
    public static class InnerTransactionResultresultUnionTxMALFORMEDGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxMALFORMEDGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxMALFORMED
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxMALFORMED)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxMALFORMED), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TxMALFORMED</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxMALFORMED> TxMALFORMEDMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxMALFORMED>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxMALFORMED>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
