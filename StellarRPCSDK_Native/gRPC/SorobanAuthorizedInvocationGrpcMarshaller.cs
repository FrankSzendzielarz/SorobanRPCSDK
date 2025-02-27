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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedInvocation</summary>
    public static class SorobanAuthorizedInvocationGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedInvocationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedInvocation
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedInvocation)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedInvocation), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "function");
                metaType.Add(2, "subInvocations");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAuthorizedInvocation</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedInvocation> SorobanAuthorizedInvocationMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedInvocation>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedInvocation>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
