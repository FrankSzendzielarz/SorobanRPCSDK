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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+PathPaymentStrictSend</summary>
    public static class OperationResulttrUnionPathPaymentStrictSendGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionPathPaymentStrictSendGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.PathPaymentStrictSend
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.PathPaymentStrictSend)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.PathPaymentStrictSend), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(14, "pathPaymentStrictSendResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictSend</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.PathPaymentStrictSend> PathPaymentStrictSendMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.PathPaymentStrictSend>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.PathPaymentStrictSend>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
