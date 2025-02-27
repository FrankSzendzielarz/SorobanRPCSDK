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
    /// <summary>Custom marshaller for Stellar.SCSpecEntry+ScSpecEntryFunctionV0</summary>
    public static class SCSpecEntryScSpecEntryFunctionV0GrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecEntryScSpecEntryFunctionV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecEntry.ScSpecEntryFunctionV0
            if (!model.IsDefined(typeof(Stellar.SCSpecEntry.ScSpecEntryFunctionV0)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecEntry.ScSpecEntryFunctionV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "functionV0");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecEntryFunctionV0</summary>
        public static readonly Marshaller<Stellar.SCSpecEntry.ScSpecEntryFunctionV0> ScSpecEntryFunctionV0Marshaller = Marshallers.Create<Stellar.SCSpecEntry.ScSpecEntryFunctionV0>(
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
                        return Serializer.Deserialize<Stellar.SCSpecEntry.ScSpecEntryFunctionV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
