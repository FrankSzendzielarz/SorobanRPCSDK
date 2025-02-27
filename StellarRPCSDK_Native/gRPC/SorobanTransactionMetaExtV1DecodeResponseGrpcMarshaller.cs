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
    /// <summary>Custom marshaller for Stellar.SorobanTransactionMetaExtV1DecodeResponse</summary>
    public static class SorobanTransactionMetaExtV1DecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanTransactionMetaExtV1DecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanTransactionMetaExtV1DecodeResponse
            if (!model.IsDefined(typeof(Stellar.SorobanTransactionMetaExtV1DecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanTransactionMetaExtV1DecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanTransactionMetaExtV1DecodeResponse</summary>
        public static readonly Marshaller<Stellar.SorobanTransactionMetaExtV1DecodeResponse> SorobanTransactionMetaExtV1DecodeResponseMarshaller = Marshallers.Create<Stellar.SorobanTransactionMetaExtV1DecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.SorobanTransactionMetaExtV1DecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
