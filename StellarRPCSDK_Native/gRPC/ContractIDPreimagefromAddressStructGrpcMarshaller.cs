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
    /// <summary>Custom marshaller for Stellar.ContractIDPreimage+fromAddressStruct</summary>
    public static class ContractIDPreimagefromAddressStructGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractIDPreimagefromAddressStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractIDPreimage.fromAddressStruct
            if (!model.IsDefined(typeof(Stellar.ContractIDPreimage.fromAddressStruct)))
            {
                var metaType = model.Add(typeof(Stellar.ContractIDPreimage.fromAddressStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "address");
                metaType.Add(2, "salt");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for fromAddressStruct</summary>
        public static readonly Marshaller<Stellar.ContractIDPreimage.fromAddressStruct> fromAddressStructMarshaller = Marshallers.Create<Stellar.ContractIDPreimage.fromAddressStruct>(
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
                        return Serializer.Deserialize<Stellar.ContractIDPreimage.fromAddressStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
