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
    /// <summary>Custom marshaller for Stellar.ClaimPredicate+ClaimPredicateUnconditional</summary>
    public static class ClaimPredicateClaimPredicateUnconditionalGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimPredicateClaimPredicateUnconditionalGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimPredicate.ClaimPredicateUnconditional
            if (!model.IsDefined(typeof(Stellar.ClaimPredicate.ClaimPredicateUnconditional)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimPredicate.ClaimPredicateUnconditional), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimPredicateUnconditional</summary>
        public static readonly Marshaller<Stellar.ClaimPredicate.ClaimPredicateUnconditional> ClaimPredicateUnconditionalMarshaller = Marshallers.Create<Stellar.ClaimPredicate.ClaimPredicateUnconditional>(
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
                        return Serializer.Deserialize<Stellar.ClaimPredicate.ClaimPredicateUnconditional>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
