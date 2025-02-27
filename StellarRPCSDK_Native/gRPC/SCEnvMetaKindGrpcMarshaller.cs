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
    /// <summary>Custom marshaller for Stellar.SCEnvMetaKind</summary>
    public static class SCEnvMetaKindGrpcMarshaller
    {
        // Static constructor to configure type
        static SCEnvMetaKindGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCEnvMetaKind
            if (!model.IsDefined(typeof(Stellar.SCEnvMetaKind)))
            {
                var metaType = model.Add(typeof(Stellar.SCEnvMetaKind), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCEnvMetaKind</summary>
        public static readonly Marshaller<Stellar.SCEnvMetaKind> SCEnvMetaKindMarshaller = Marshallers.Create<Stellar.SCEnvMetaKind>(
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
                        return Serializer.Deserialize<Stellar.SCEnvMetaKind>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
