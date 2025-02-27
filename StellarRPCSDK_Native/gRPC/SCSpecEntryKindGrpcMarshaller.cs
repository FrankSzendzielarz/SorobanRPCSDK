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
    /// <summary>Custom marshaller for Stellar.SCSpecEntryKind</summary>
    public static class SCSpecEntryKindGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecEntryKindGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecEntryKind
            if (!model.IsDefined(typeof(Stellar.SCSpecEntryKind)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecEntryKind), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecEntryKind</summary>
        public static readonly Marshaller<Stellar.SCSpecEntryKind> SCSpecEntryKindMarshaller = Marshallers.Create<Stellar.SCSpecEntryKind>(
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
                        return Serializer.Deserialize<Stellar.SCSpecEntryKind>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
