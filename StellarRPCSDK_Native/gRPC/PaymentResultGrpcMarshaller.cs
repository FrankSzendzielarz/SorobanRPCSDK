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
    /// <summary>Custom marshaller for Stellar.PaymentResult</summary>
    public static class PaymentResultGrpcMarshaller
    {
        // Static constructor to configure type
        static PaymentResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PaymentResult
            if (!model.IsDefined(typeof(Stellar.PaymentResult)))
            {
                var metaType = model.Add(typeof(Stellar.PaymentResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.PaymentResult.PaymentSuccess));
                metaType.AddSubType(101, typeof(Stellar.PaymentResult.PaymentMalformed));
                metaType.AddSubType(102, typeof(Stellar.PaymentResult.PaymentUnderfunded));
                metaType.AddSubType(103, typeof(Stellar.PaymentResult.PaymentSrcNoTrust));
                metaType.AddSubType(104, typeof(Stellar.PaymentResult.PaymentSrcNotAuthorized));
                metaType.AddSubType(105, typeof(Stellar.PaymentResult.PaymentNoDestination));
                metaType.AddSubType(106, typeof(Stellar.PaymentResult.PaymentNoTrust));
                metaType.AddSubType(107, typeof(Stellar.PaymentResult.PaymentNotAuthorized));
                metaType.AddSubType(108, typeof(Stellar.PaymentResult.PaymentLineFull));
                metaType.AddSubType(109, typeof(Stellar.PaymentResult.PaymentNoIssuer));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PaymentResult</summary>
        public static readonly Marshaller<Stellar.PaymentResult> PaymentResultMarshaller = Marshallers.Create<Stellar.PaymentResult>(
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
                        return Serializer.Deserialize<Stellar.PaymentResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
