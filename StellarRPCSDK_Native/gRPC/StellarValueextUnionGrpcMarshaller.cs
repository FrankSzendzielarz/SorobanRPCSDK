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
    /// <summary>Custom marshaller for Stellar.StellarValue+extUnion</summary>
    public static class StellarValueextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarValueextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarValue.extUnion
            if (!model.IsDefined(typeof(Stellar.StellarValue.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.StellarValue.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.StellarValue.extUnion.StellarValueBasic));
                metaType.AddSubType(101, typeof(Stellar.StellarValue.extUnion.StellarValueSigned));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for extUnion</summary>
        public static readonly Marshaller<Stellar.StellarValue.extUnion> extUnionMarshaller = Marshallers.Create<Stellar.StellarValue.extUnion>(
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
                        return Serializer.Deserialize<Stellar.StellarValue.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
