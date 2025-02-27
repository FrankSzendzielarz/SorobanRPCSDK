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
    /// <summary>Custom marshaller for Stellar.ManageDataResult</summary>
    public static class ManageDataResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageDataResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageDataResult
            if (!model.IsDefined(typeof(Stellar.ManageDataResult)))
            {
                var metaType = model.Add(typeof(Stellar.ManageDataResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ManageDataResult.ManageDataSuccess));
                metaType.AddSubType(101, typeof(Stellar.ManageDataResult.ManageDataNotSupportedYet));
                metaType.AddSubType(102, typeof(Stellar.ManageDataResult.ManageDataNameNotFound));
                metaType.AddSubType(103, typeof(Stellar.ManageDataResult.ManageDataLowReserve));
                metaType.AddSubType(104, typeof(Stellar.ManageDataResult.ManageDataInvalidName));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageDataResult</summary>
        public static readonly Marshaller<Stellar.ManageDataResult> ManageDataResultMarshaller = Marshallers.Create<Stellar.ManageDataResult>(
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
                        return Serializer.Deserialize<Stellar.ManageDataResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
