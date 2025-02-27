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
    /// <summary>Custom marshaller for Stellar.TransactionSet</summary>
    public static class TransactionSetGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSet
            if (!model.IsDefined(typeof(Stellar.TransactionSet)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSet), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "previousLedgerHash");
                metaType.Add(2, "txs");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionSet</summary>
        public static readonly Marshaller<Stellar.TransactionSet> TransactionSetMarshaller = Marshallers.Create<Stellar.TransactionSet>(
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
                        return Serializer.Deserialize<Stellar.TransactionSet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
