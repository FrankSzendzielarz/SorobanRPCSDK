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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvAddress</summary>
    public static class SCValScvAddressGrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvAddressGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvAddress
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvAddress)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvAddress), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(18, "address");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal+ScvAddress</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvAddress> SCVal_ScvAddressMarshaller = Marshallers.Create<Stellar.SCVal.ScvAddress>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvAddress>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
