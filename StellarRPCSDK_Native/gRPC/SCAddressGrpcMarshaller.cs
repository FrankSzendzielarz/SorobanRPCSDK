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
    /// <summary>Custom marshaller for Stellar.SCAddress</summary>
    public static class SCAddressGrpcMarshaller
    {
        // Static constructor to configure type
        static SCAddressGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCAddress
            if (!model.IsDefined(typeof(Stellar.SCAddress)))
            {
                var metaType = model.Add(typeof(Stellar.SCAddress), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCAddress.ScAddressTypeAccount));
                metaType.AddSubType(101, typeof(Stellar.SCAddress.ScAddressTypeContract));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCAddress</summary>
        public static readonly Marshaller<Stellar.SCAddress> SCAddressMarshaller = Marshallers.Create<Stellar.SCAddress>(
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
                        return Serializer.Deserialize<Stellar.SCAddress>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
