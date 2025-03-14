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
    /// <summary>Custom marshaller for Stellar.ContractIDPreimage+ContractIdPreimageFromAddress</summary>
    public static class ContractIDPreimageContractIdPreimageFromAddressGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractIDPreimageContractIdPreimageFromAddressGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractIDPreimage.ContractIdPreimageFromAddress
            if (!model.IsDefined(typeof(Stellar.ContractIDPreimage.ContractIdPreimageFromAddress)))
            {
                var metaType = model.Add(typeof(Stellar.ContractIDPreimage.ContractIdPreimageFromAddress), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "fromAddress");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractIDPreimage+ContractIdPreimageFromAddress</summary>
        public static readonly Marshaller<Stellar.ContractIDPreimage.ContractIdPreimageFromAddress> ContractIDPreimage_ContractIdPreimageFromAddressMarshaller = Marshallers.Create<Stellar.ContractIDPreimage.ContractIdPreimageFromAddress>(
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
                        return Serializer.Deserialize<Stellar.ContractIDPreimage.ContractIdPreimageFromAddress>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
