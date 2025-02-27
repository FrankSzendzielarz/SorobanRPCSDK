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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictSendResult+successStruct</summary>
    public static class PathPaymentStrictSendResultsuccessStructGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictSendResultsuccessStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictSendResult.successStruct
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictSendResult.successStruct)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictSendResult.successStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "offers");
                metaType.Add(2, "last");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for successStruct</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictSendResult.successStruct> successStructMarshaller = Marshallers.Create<Stellar.PathPaymentStrictSendResult.successStruct>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictSendResult.successStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
