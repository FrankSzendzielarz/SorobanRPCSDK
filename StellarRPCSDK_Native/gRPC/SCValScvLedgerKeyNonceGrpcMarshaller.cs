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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvLedgerKeyNonce</summary>
    public static class SCValScvLedgerKeyNonceGrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvLedgerKeyNonceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvLedgerKeyNonce
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvLedgerKeyNonce)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvLedgerKeyNonce), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(19, "nonce_key");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal+ScvLedgerKeyNonce</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvLedgerKeyNonce> SCVal_ScvLedgerKeyNonceMarshaller = Marshallers.Create<Stellar.SCVal.ScvLedgerKeyNonce>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvLedgerKeyNonce>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
