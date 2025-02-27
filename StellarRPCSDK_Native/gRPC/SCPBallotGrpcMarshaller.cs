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
    /// <summary>Custom marshaller for Stellar.SCPBallot</summary>
    public static class SCPBallotGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPBallotGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPBallot
            if (!model.IsDefined(typeof(Stellar.SCPBallot)))
            {
                var metaType = model.Add(typeof(Stellar.SCPBallot), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "counter");
                metaType.Add(2, "value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCPBallot</summary>
        public static readonly Marshaller<Stellar.SCPBallot> SCPBallotMarshaller = Marshallers.Create<Stellar.SCPBallot>(
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
                        return Serializer.Deserialize<Stellar.SCPBallot>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
