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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvU64</summary>
    public static class SCValScvU64GrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvU64GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvU64
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvU64)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvU64), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "u64");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal+ScvU64</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvU64> SCVal_ScvU64Marshaller = Marshallers.Create<Stellar.SCVal.ScvU64>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvU64>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
