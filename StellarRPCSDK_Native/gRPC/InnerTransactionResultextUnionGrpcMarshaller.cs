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
    /// <summary>Custom marshaller for Stellar.InnerTransactionResult+extUnion</summary>
    public static class InnerTransactionResultextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static InnerTransactionResultextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InnerTransactionResult.extUnion
            if (!model.IsDefined(typeof(Stellar.InnerTransactionResult.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.InnerTransactionResult.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.InnerTransactionResult.extUnion.case_0));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InnerTransactionResult+extUnion</summary>
        public static readonly Marshaller<Stellar.InnerTransactionResult.extUnion> InnerTransactionResult_extUnionMarshaller = Marshallers.Create<Stellar.InnerTransactionResult.extUnion>(
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
                        return Serializer.Deserialize<Stellar.InnerTransactionResult.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
