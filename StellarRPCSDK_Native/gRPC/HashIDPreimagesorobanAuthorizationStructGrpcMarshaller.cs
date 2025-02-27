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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+sorobanAuthorizationStruct</summary>
    public static class HashIDPreimagesorobanAuthorizationStructGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimagesorobanAuthorizationStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.sorobanAuthorizationStruct
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.sorobanAuthorizationStruct)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.sorobanAuthorizationStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "networkID");
                metaType.Add(2, "nonce");
                metaType.Add(3, "signatureExpirationLedger");
                metaType.Add(4, "invocation");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for sorobanAuthorizationStruct</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.sorobanAuthorizationStruct> sorobanAuthorizationStructMarshaller = Marshallers.Create<Stellar.HashIDPreimage.sorobanAuthorizationStruct>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.sorobanAuthorizationStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
