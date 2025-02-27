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
    /// <summary>Custom marshaller for Stellar.PaymentOp</summary>
    public static class PaymentOpGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentOp
            if (!model.IsDefined(typeof(Stellar.PaymentOp)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "destination");
                metaType.Add(2, "asset");
                metaType.Add(3, "amount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PaymentOp</summary>
        public static readonly Marshaller<Stellar.PaymentOp> PaymentOpMarshaller = Marshallers.Create<Stellar.PaymentOp>(
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
                        return Serializer.Deserialize<Stellar.PaymentOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
