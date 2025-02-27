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
    /// <summary>Custom marshaller for Stellar.StoredDebugTransactionSet</summary>
    public static class StoredDebugTransactionSetGrpcMarshaller
    {
        // Static constructor to configure type
        static StoredDebugTransactionSetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StoredDebugTransactionSet
            if (!model.IsDefined(typeof(Stellar.StoredDebugTransactionSet)))
            {
                var metaType = model.Add(typeof(Stellar.StoredDebugTransactionSet), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txSet");
                metaType.Add(2, "ledgerSeq");
                metaType.Add(3, "scpValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StoredDebugTransactionSet</summary>
        public static readonly Marshaller<Stellar.StoredDebugTransactionSet> StoredDebugTransactionSetMarshaller = Marshallers.Create<Stellar.StoredDebugTransactionSet>(
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
                        return Serializer.Deserialize<Stellar.StoredDebugTransactionSet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
