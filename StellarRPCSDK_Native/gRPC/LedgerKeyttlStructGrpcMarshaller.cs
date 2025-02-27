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
    /// <summary>Custom marshaller for Stellar.LedgerKey+ttlStruct</summary>
    public static class LedgerKeyttlStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyttlStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.ttlStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.ttlStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.ttlStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "keyHash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+ttlStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.ttlStruct> LedgerKey_ttlStructMarshaller = Marshallers.Create<Stellar.LedgerKey.ttlStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.ttlStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
