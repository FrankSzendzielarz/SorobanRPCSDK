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
    /// <summary>Custom marshaller for Stellar.SCPNomination</summary>
    public static class SCPNominationGrpcMarshaller
    {
        // Static constructor to configure type
        static SCPNominationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCPNomination
            if (!model.IsDefined(typeof(Stellar.SCPNomination)))
            {
                var metaType = model.Add(typeof(Stellar.SCPNomination), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "quorumSetHash");
                metaType.Add(2, "votes");
                metaType.Add(3, "accepted");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCPNomination</summary>
        public static readonly Marshaller<Stellar.SCPNomination> SCPNominationMarshaller = Marshallers.Create<Stellar.SCPNomination>(
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
                        return Serializer.Deserialize<Stellar.SCPNomination>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
