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
    /// <summary>Custom marshaller for Stellar.SCSpecEntry+ScSpecEntryUdtErrorEnumV0</summary>
    public static class SCSpecEntryScSpecEntryUdtErrorEnumV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecEntryScSpecEntryUdtErrorEnumV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0
            if (!model.IsDefined(typeof(Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "udtErrorEnumV0");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecEntry+ScSpecEntryUdtErrorEnumV0</summary>
        public static readonly Marshaller<Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0> SCSpecEntry_ScSpecEntryUdtErrorEnumV0Marshaller = Marshallers.Create<Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
