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
    /// <summary>Custom marshaller for Stellar.TransactionMetaV3</summary>
    public static class TransactionMetaV3GrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionMetaV3GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionMetaV3
            if (!model.IsDefined(typeof(Stellar.TransactionMetaV3)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionMetaV3), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "txChangesBefore");
                metaType.Add(3, "operations");
                metaType.Add(4, "txChangesAfter");
                metaType.Add(5, "sorobanMeta");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionMetaV3</summary>
        public static readonly Marshaller<Stellar.TransactionMetaV3> TransactionMetaV3Marshaller = Marshallers.Create<Stellar.TransactionMetaV3>(
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
                        return Serializer.Deserialize<Stellar.TransactionMetaV3>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
