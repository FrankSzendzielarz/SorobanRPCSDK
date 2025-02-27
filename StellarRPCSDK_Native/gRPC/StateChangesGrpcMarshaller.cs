// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.StateChanges</summary>
    public static class StateChangesGrpcMarshaller
    {
        // Static constructor to configure type
        static StateChangesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.StateChanges
            if (!model.IsDefined(typeof(Stellar.RPC.StateChanges)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.StateChanges), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Type");
                metaType.Add(2, "Key");
                metaType.Add(3, "Before");
                metaType.Add(4, "After");
                metaType.Add(100, "LedgerBefore");
                metaType.Add(101, "LedgerAfter");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for StateChanges</summary>
        public static readonly Marshaller<Stellar.RPC.StateChanges> StateChangesMarshaller = Marshallers.Create<Stellar.RPC.StateChanges>(
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
                        return Serializer.Deserialize<Stellar.RPC.StateChanges>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
