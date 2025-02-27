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
    /// <summary>Custom marshaller for Stellar.SerializedBinaryFuseFilter</summary>
    public static class SerializedBinaryFuseFilterGrpcMarshaller
    {
        // Static constructor to configure type
        static SerializedBinaryFuseFilterGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SerializedBinaryFuseFilter
            if (!model.IsDefined(typeof(Stellar.SerializedBinaryFuseFilter)))
            {
                var metaType = model.Add(typeof(Stellar.SerializedBinaryFuseFilter), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "type");
                metaType.Add(2, "inputHashSeed");
                metaType.Add(3, "filterSeed");
                metaType.Add(4, "segmentLength");
                metaType.Add(5, "segementLengthMask");
                metaType.Add(6, "segmentCount");
                metaType.Add(7, "segmentCountLength");
                metaType.Add(8, "fingerprintLength");
                metaType.Add(9, "fingerprints");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SerializedBinaryFuseFilter</summary>
        public static readonly Marshaller<Stellar.SerializedBinaryFuseFilter> SerializedBinaryFuseFilterMarshaller = Marshallers.Create<Stellar.SerializedBinaryFuseFilter>(
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
                        return Serializer.Deserialize<Stellar.SerializedBinaryFuseFilter>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
