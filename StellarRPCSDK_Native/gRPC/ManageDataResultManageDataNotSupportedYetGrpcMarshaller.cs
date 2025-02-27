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
    /// <summary>Custom marshaller for Stellar.ManageDataResult+ManageDataNotSupportedYet</summary>
    public static class ManageDataResultManageDataNotSupportedYetGrpcMarshaller
    {
        // Static constructor to configure type
        static ManageDataResultManageDataNotSupportedYetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ManageDataResult.ManageDataNotSupportedYet
            if (!model.IsDefined(typeof(Stellar.ManageDataResult.ManageDataNotSupportedYet)))
            {
                var metaType = model.Add(typeof(Stellar.ManageDataResult.ManageDataNotSupportedYet), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ManageDataNotSupportedYet</summary>
        public static readonly Marshaller<Stellar.ManageDataResult.ManageDataNotSupportedYet> ManageDataNotSupportedYetMarshaller = Marshallers.Create<Stellar.ManageDataResult.ManageDataNotSupportedYet>(
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
                        return Serializer.Deserialize<Stellar.ManageDataResult.ManageDataNotSupportedYet>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
