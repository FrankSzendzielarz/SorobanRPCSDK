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
    /// <summary>Custom marshaller for Stellar.Claimant+v0Struct</summary>
    public static class Claimantv0StructGrpcMarshaller
    {
        // Static constructor to configure type
        static Claimantv0StructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Claimant.v0Struct
            if (!model.IsDefined(typeof(Stellar.Claimant.v0Struct)))
            {
                var metaType = model.Add(typeof(Stellar.Claimant.v0Struct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "destination");
                metaType.Add(2, "predicate");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for v0Struct</summary>
        public static readonly Marshaller<Stellar.Claimant.v0Struct> v0StructMarshaller = Marshallers.Create<Stellar.Claimant.v0Struct>(
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
                        return Serializer.Deserialize<Stellar.Claimant.v0Struct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
