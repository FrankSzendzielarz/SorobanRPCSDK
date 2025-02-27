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
    /// <summary>Custom marshaller for Stellar.SCPQuorumSet</summary>
    public static class SCPQuorumSetGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPQuorumSetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPQuorumSet
            if (!model.IsDefined(typeof(Stellar.SCPQuorumSet)))
            {
                var metaType = model.Add(typeof(Stellar.SCPQuorumSet), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "threshold");
                metaType.Add(2, "validators");
                metaType.Add(3, "innerSets");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCPQuorumSet</summary>
        public static readonly Marshaller<Stellar.SCPQuorumSet> SCPQuorumSetMarshaller = Marshallers.Create<Stellar.SCPQuorumSet>(
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
                        return Serializer.Deserialize<Stellar.SCPQuorumSet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
