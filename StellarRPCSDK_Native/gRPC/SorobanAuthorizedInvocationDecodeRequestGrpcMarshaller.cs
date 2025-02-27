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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedInvocationDecodeRequest</summary>
    public static class SorobanAuthorizedInvocationDecodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedInvocationDecodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedInvocationDecodeRequest
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedInvocationDecodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedInvocationDecodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAuthorizedInvocationDecodeRequest</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedInvocationDecodeRequest> SorobanAuthorizedInvocationDecodeRequestMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedInvocationDecodeRequest>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedInvocationDecodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
