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
    /// <summary>Custom marshaller for Stellar.Liabilities</summary>
    public static class LiabilitiesGrpcMarshaller
    {
        // Static constructor to configure type
        static LiabilitiesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Liabilities
            if (!model.IsDefined(typeof(Stellar.Liabilities)))
            {
                var metaType = model.Add(typeof(Stellar.Liabilities), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "buying");
                metaType.Add(2, "selling");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Liabilities</summary>
        public static readonly Marshaller<Stellar.Liabilities> LiabilitiesMarshaller = Marshallers.Create<Stellar.Liabilities>(
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
                        return Serializer.Deserialize<Stellar.Liabilities>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
