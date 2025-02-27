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
    /// <summary>Custom marshaller for Stellar.TransactionV0</summary>
    public static class TransactionV0GrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionV0
            if (!model.IsDefined(typeof(Stellar.TransactionV0)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sourceAccountEd25519");
                metaType.Add(2, "fee");
                metaType.Add(3, "seqNum");
                metaType.Add(4, "timeBounds");
                metaType.Add(5, "memo");
                metaType.Add(6, "operations");
                metaType.Add(7, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionV0</summary>
        public static readonly Marshaller<Stellar.TransactionV0> TransactionV0Marshaller = Marshallers.Create<Stellar.TransactionV0>(
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
                        return Serializer.Deserialize<Stellar.TransactionV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
