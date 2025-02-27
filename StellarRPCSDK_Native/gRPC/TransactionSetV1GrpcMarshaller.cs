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
    /// <summary>Custom marshaller for Stellar.TransactionSetV1</summary>
    public static class TransactionSetV1GrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSetV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSetV1
            if (!model.IsDefined(typeof(Stellar.TransactionSetV1)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSetV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "previousLedgerHash");
                metaType.Add(2, "phases");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionSetV1</summary>
        public static readonly Marshaller<Stellar.TransactionSetV1> TransactionSetV1Marshaller = Marshallers.Create<Stellar.TransactionSetV1>(
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
                        return Serializer.Deserialize<Stellar.TransactionSetV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
