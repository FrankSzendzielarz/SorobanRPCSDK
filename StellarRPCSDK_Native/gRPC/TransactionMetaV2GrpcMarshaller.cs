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
    /// <summary>Custom marshaller for Stellar.TransactionMetaV2</summary>
    public static class TransactionMetaV2GrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionMetaV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionMetaV2
            if (!model.IsDefined(typeof(Stellar.TransactionMetaV2)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionMetaV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txChangesBefore");
                metaType.Add(2, "operations");
                metaType.Add(3, "txChangesAfter");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionMetaV2</summary>
        public static readonly Marshaller<Stellar.TransactionMetaV2> TransactionMetaV2Marshaller = Marshallers.Create<Stellar.TransactionMetaV2>(
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
                        return Serializer.Deserialize<Stellar.TransactionMetaV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
