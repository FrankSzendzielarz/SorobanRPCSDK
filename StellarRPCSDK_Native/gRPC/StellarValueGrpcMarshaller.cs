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
    /// <summary>Custom marshaller for Stellar.StellarValue</summary>
    public static class StellarValueGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarValueGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarValue
            if (!model.IsDefined(typeof(Stellar.StellarValue)))
            {
                var metaType = model.Add(typeof(Stellar.StellarValue), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txSetHash");
                metaType.Add(2, "closeTime");
                metaType.Add(3, "upgrades");
                metaType.Add(4, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarValue</summary>
        public static readonly Marshaller<Stellar.StellarValue> StellarValueMarshaller = Marshallers.Create<Stellar.StellarValue>(
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
                        return Serializer.Deserialize<Stellar.StellarValue>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
