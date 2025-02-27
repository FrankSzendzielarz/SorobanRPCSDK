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
    /// <summary>Custom marshaller for Stellar.PathPaymentStrictReceiveResult+PathPaymentStrictReceiveNoIssuer</summary>
    public static class PathPaymentStrictReceiveResultPathPaymentStrictReceiveNoIssuerGrpcMarshaller
    {
        // Static constructor to configure type
        static PathPaymentStrictReceiveResultPathPaymentStrictReceiveNoIssuerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer
            if (!model.IsDefined(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer)))
            {
                var metaType = model.Add(typeof(Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "noIssuer");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PathPaymentStrictReceiveNoIssuer</summary>
        public static readonly Marshaller<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer> PathPaymentStrictReceiveNoIssuerMarshaller = Marshallers.Create<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer>(
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
                        return Serializer.Deserialize<Stellar.PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
