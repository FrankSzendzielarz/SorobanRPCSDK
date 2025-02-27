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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxnotSupported</summary>
    public static class InnerTransactionResultresultUnionTxnotSupportedGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxnotSupportedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxnotSupported
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxnotSupported)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxnotSupported), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+resultUnion+TxnotSupported</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxnotSupported> InnerTransactionResult_resultUnion_TxnotSupportedMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxnotSupported>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxnotSupported>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
