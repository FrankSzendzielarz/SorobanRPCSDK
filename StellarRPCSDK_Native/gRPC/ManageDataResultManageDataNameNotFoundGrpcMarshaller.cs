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
    /// <summary>Custom marshaller for Stellar.ManageDataResult+ManageDataNameNotFound</summary>
    public static class ManageDataResultManageDataNameNotFoundGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageDataResultManageDataNameNotFoundGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageDataResult.ManageDataNameNotFound
            if (!model.IsDefined(typeof(Stellar.ManageDataResult.ManageDataNameNotFound)))
            {
                var metaType = model.Add(typeof(Stellar.ManageDataResult.ManageDataNameNotFound), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ManageDataResult+ManageDataNameNotFound</summary>
        public static readonly Marshaller<Stellar.ManageDataResult.ManageDataNameNotFound> ManageDataResult_ManageDataNameNotFoundMarshaller = Marshallers.Create<Stellar.ManageDataResult.ManageDataNameNotFound>(
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
                        return Serializer.Deserialize<Stellar.ManageDataResult.ManageDataNameNotFound>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
