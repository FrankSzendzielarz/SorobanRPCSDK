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
    /// <summary>Custom marshaller for Stellar.TransactionMeta</summary>
    public static class TransactionMetaGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionMetaGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionMeta
            if (!model.IsDefined(typeof(Stellar.TransactionMeta)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionMeta), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TransactionMeta.case_0));
                metaType.AddSubType(101, typeof(Stellar.TransactionMeta.case_1));
                metaType.AddSubType(102, typeof(Stellar.TransactionMeta.case_2));
                metaType.AddSubType(103, typeof(Stellar.TransactionMeta.case_3));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionMeta</summary>
        public static readonly Marshaller<Stellar.TransactionMeta> TransactionMetaMarshaller = Marshallers.Create<Stellar.TransactionMeta>(
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
                        return Serializer.Deserialize<Stellar.TransactionMeta>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
