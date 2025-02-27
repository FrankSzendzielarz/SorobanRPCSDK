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
    /// <summary>Custom marshaller for Stellar.TransactionResultPair</summary>
    public static class TransactionResultPairGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionResultPairGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionResultPair
            if (!model.IsDefined(typeof(Stellar.TransactionResultPair)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionResultPair), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "transactionHash");
                metaType.Add(2, "result");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionResultPair</summary>
        public static readonly Marshaller<Stellar.TransactionResultPair> TransactionResultPairMarshaller = Marshallers.Create<Stellar.TransactionResultPair>(
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
                        return Serializer.Deserialize<Stellar.TransactionResultPair>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
