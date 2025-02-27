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
    /// <summary>Custom marshaller for Stellar.SCSpecEntry</summary>
    public static class SCSpecEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecEntry
            if (!model.IsDefined(typeof(Stellar.SCSpecEntry)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCSpecEntry.ScSpecEntryFunctionV0));
                metaType.AddSubType(101, typeof(Stellar.SCSpecEntry.ScSpecEntryUdtStructV0));
                metaType.AddSubType(102, typeof(Stellar.SCSpecEntry.ScSpecEntryUdtUnionV0));
                metaType.AddSubType(103, typeof(Stellar.SCSpecEntry.ScSpecEntryUdtEnumV0));
                metaType.AddSubType(104, typeof(Stellar.SCSpecEntry.ScSpecEntryUdtErrorEnumV0));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCSpecEntry</summary>
        public static readonly Marshaller<Stellar.SCSpecEntry> SCSpecEntryMarshaller = Marshallers.Create<Stellar.SCSpecEntry>(
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
                        return Serializer.Deserialize<Stellar.SCSpecEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
