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
    /// <summary>Custom marshaller for Stellar.LedgerKey+offerStruct</summary>
    public static class LedgerKeyofferStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyofferStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.offerStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.offerStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.offerStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sellerID");
                metaType.Add(2, "offerID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+offerStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.offerStruct> LedgerKey_offerStructMarshaller = Marshallers.Create<Stellar.LedgerKey.offerStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.offerStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
