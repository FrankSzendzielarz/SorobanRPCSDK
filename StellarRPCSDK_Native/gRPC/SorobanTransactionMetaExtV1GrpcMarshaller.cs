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
    /// <summary>Custom marshaller for Stellar.SorobanTransactionMetaExtV1</summary>
    public static class SorobanTransactionMetaExtV1GrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanTransactionMetaExtV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanTransactionMetaExtV1
            if (!model.IsDefined(typeof(Stellar.SorobanTransactionMetaExtV1)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanTransactionMetaExtV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "totalNonRefundableResourceFeeCharged");
                metaType.Add(3, "totalRefundableResourceFeeCharged");
                metaType.Add(4, "rentFeeCharged");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanTransactionMetaExtV1</summary>
        public static readonly Marshaller<Stellar.SorobanTransactionMetaExtV1> SorobanTransactionMetaExtV1Marshaller = Marshallers.Create<Stellar.SorobanTransactionMetaExtV1>(
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
                        return Serializer.Deserialize<Stellar.SorobanTransactionMetaExtV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
