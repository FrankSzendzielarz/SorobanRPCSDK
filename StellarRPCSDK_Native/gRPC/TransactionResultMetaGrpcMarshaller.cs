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
    /// <summary>Custom marshaller for Stellar.TransactionResultMeta</summary>
    public static class TransactionResultMetaGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultMetaGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResultMeta
            if (!model.IsDefined(typeof(Stellar.TransactionResultMeta)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResultMeta), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "result");
                metaType.Add(2, "feeProcessing");
                metaType.Add(3, "txApplyProcessing");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionResultMeta</summary>
        public static readonly Marshaller<Stellar.TransactionResultMeta> TransactionResultMetaMarshaller = Marshallers.Create<Stellar.TransactionResultMeta>(
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
                        return Serializer.Deserialize<Stellar.TransactionResultMeta>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
