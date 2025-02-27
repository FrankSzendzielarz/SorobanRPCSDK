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
    /// <summary>Custom marshaller for Stellar.FeeBumpTransaction</summary>
    public static class FeeBumpTransactionGrpcMarshaller
    {
        // Static constructor to configure type
        static FeeBumpTransactionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.FeeBumpTransaction
            if (!model.IsDefined(typeof(Stellar.FeeBumpTransaction)))
            {
                var metaType = model.Add(typeof(Stellar.FeeBumpTransaction), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "feeSource");
                metaType.Add(2, "fee");
                metaType.Add(3, "innerTx");
                metaType.Add(4, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for FeeBumpTransaction</summary>
        public static readonly Marshaller<Stellar.FeeBumpTransaction> FeeBumpTransactionMarshaller = Marshallers.Create<Stellar.FeeBumpTransaction>(
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
                        return Serializer.Deserialize<Stellar.FeeBumpTransaction>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
