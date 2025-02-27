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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+resultUnion+TxtooEarly</summary>
    public static class InnerTransactionResultresultUnionTxtooEarlyGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultresultUnionTxtooEarlyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.resultUnion.TxtooEarly
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.resultUnion.TxtooEarly)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.resultUnion.TxtooEarly), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TxtooEarly</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.resultUnion.TxtooEarly> TxtooEarlyMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.resultUnion.TxtooEarly>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.resultUnion.TxtooEarly>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
