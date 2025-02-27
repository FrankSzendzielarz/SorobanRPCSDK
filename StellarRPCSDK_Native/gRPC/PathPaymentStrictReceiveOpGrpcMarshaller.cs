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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictReceiveOp</summary>
    public static class PathPaymentStrictReceiveOpGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictReceiveOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictReceiveOp
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictReceiveOp)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictReceiveOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sendAsset");
                metaType.Add(2, "sendMax");
                metaType.Add(3, "destination");
                metaType.Add(4, "destAsset");
                metaType.Add(5, "destAmount");
                metaType.Add(6, "path");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictReceiveOp</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictReceiveOp> PathPaymentStrictReceiveOpMarshaller = Marshallers.Create<Stellar.PathPaymentStrictReceiveOp>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictReceiveOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
