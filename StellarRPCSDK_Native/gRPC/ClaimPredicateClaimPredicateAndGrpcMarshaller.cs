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
    /// <summary>Custom marshaller for Stellar.ClaimPredicate+ClaimPredicateAnd</summary>
    public static class ClaimPredicateClaimPredicateAndGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimPredicateClaimPredicateAndGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimPredicate.ClaimPredicateAnd
            if (!model.IsDefined(typeof(Stellar.ClaimPredicate.ClaimPredicateAnd)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimPredicate.ClaimPredicateAnd), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "andPredicates");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimPredicate+ClaimPredicateAnd</summary>
        public static readonly Marshaller<Stellar.ClaimPredicate.ClaimPredicateAnd> ClaimPredicate_ClaimPredicateAndMarshaller = Marshallers.Create<Stellar.ClaimPredicate.ClaimPredicateAnd>(
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
                        return Serializer.Deserialize<Stellar.ClaimPredicate.ClaimPredicateAnd>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
