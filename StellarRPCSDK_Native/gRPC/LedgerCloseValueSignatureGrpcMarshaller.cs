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
    /// <summary>Custom marshaller for Stellar.LedgerCloseValueSignature</summary>
    public static class LedgerCloseValueSignatureGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerCloseValueSignatureGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerCloseValueSignature
            if (!model.IsDefined(typeof(Stellar.LedgerCloseValueSignature)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerCloseValueSignature), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "nodeID");
                metaType.Add(2, "signature");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerCloseValueSignature</summary>
        public static readonly Marshaller<Stellar.LedgerCloseValueSignature> LedgerCloseValueSignatureMarshaller = Marshallers.Create<Stellar.LedgerCloseValueSignature>(
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
                        return Serializer.Deserialize<Stellar.LedgerCloseValueSignature>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
