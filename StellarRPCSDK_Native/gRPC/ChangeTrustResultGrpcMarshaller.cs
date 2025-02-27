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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult</summary>
    public static class ChangeTrustResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ChangeTrustResult.ChangeTrustSuccess));
                metaType.AddSubType(101, typeof(Stellar.ChangeTrustResult.ChangeTrustMalformed));
                metaType.AddSubType(102, typeof(Stellar.ChangeTrustResult.ChangeTrustNoIssuer));
                metaType.AddSubType(103, typeof(Stellar.ChangeTrustResult.ChangeTrustInvalidLimit));
                metaType.AddSubType(104, typeof(Stellar.ChangeTrustResult.ChangeTrustLowReserve));
                metaType.AddSubType(105, typeof(Stellar.ChangeTrustResult.ChangeTrustSelfNotAllowed));
                metaType.AddSubType(106, typeof(Stellar.ChangeTrustResult.ChangeTrustTrustLineMissing));
                metaType.AddSubType(107, typeof(Stellar.ChangeTrustResult.ChangeTrustCannotDelete));
                metaType.AddSubType(108, typeof(Stellar.ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult> ChangeTrustResultMarshaller = Marshallers.Create<Stellar.ChangeTrustResult>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
