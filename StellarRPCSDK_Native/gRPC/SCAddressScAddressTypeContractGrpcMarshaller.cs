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
    /// <summary>Custom marshaller for Stellar.SCAddress+ScAddressTypeContract</summary>
    public static class SCAddressScAddressTypeContractGrpcMarshaller
    {
        // Static constructor to configure type
        static SCAddressScAddressTypeContractGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCAddress.ScAddressTypeContract
            if (!model.IsDefined(typeof(Stellar.SCAddress.ScAddressTypeContract)))
            {
                var metaType = model.Add(typeof(Stellar.SCAddress.ScAddressTypeContract), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "contractId");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScAddressTypeContract</summary>
        public static readonly Marshaller<Stellar.SCAddress.ScAddressTypeContract> ScAddressTypeContractMarshaller = Marshallers.Create<Stellar.SCAddress.ScAddressTypeContract>(
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
                        return Serializer.Deserialize<Stellar.SCAddress.ScAddressTypeContract>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
