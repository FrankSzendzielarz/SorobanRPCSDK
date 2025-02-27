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
    /// <summary>Custom marshaller for Stellar.StellarValue+extUnion+StellarValueBasic</summary>
    public static class StellarValueextUnionStellarValueBasicGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarValueextUnionStellarValueBasicGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarValue.extUnion.StellarValueBasic
            if (!model.IsDefined(typeof(Stellar.StellarValue.extUnion.StellarValueBasic)))
            {
                var metaType = model.Add(typeof(Stellar.StellarValue.extUnion.StellarValueBasic), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarValue+extUnion+StellarValueBasic</summary>
        public static readonly Marshaller<Stellar.StellarValue.extUnion.StellarValueBasic> StellarValue_extUnion_StellarValueBasicMarshaller = Marshallers.Create<Stellar.StellarValue.extUnion.StellarValueBasic>(
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
                        return Serializer.Deserialize<Stellar.StellarValue.extUnion.StellarValueBasic>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
