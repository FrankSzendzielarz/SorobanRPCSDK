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
    /// <summary>Custom marshaller for Stellar.ClaimPredicate+ClaimPredicateOr</summary>
    public static class ClaimPredicateClaimPredicateOrGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimPredicateClaimPredicateOrGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimPredicate.ClaimPredicateOr
            if (!model.IsDefined(typeof(Stellar.ClaimPredicate.ClaimPredicateOr)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimPredicate.ClaimPredicateOr), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "orPredicates");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimPredicateOr</summary>
        public static readonly Marshaller<Stellar.ClaimPredicate.ClaimPredicateOr> ClaimPredicateOrMarshaller = Marshallers.Create<Stellar.ClaimPredicate.ClaimPredicateOr>(
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
                        return Serializer.Deserialize<Stellar.ClaimPredicate.ClaimPredicateOr>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
