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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxbadAuth</summary>
    public static class InnerTransactionResultresultUnionTxbadAuthGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxbadAuthGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxbadAuth
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadAuth)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxbadAuth), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TxbadAuth</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxbadAuth> TxbadAuthMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxbadAuth>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxbadAuth>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
