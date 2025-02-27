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
    /// <summary>Custom marshaller for Stellar.TransactionResult</summary>
    public static class TransactionResultGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResult
            if (!model.IsDefined(typeof(Stellar.TransactionResult)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "feeCharged");
                metaType.Add(2, "result");
                metaType.Add(3, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionResult</summary>
        public static readonly Marshaller<Stellar.TransactionResult> TransactionResultMarshaller = Marshallers.Create<Stellar.TransactionResult>(
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
                        return Serializer.Deserialize<Stellar.TransactionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
