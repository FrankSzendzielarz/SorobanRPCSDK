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
    /// <summary>Custom marshaller for Stellar.ClaimPredicate+ClaimPredicateBeforeAbsoluteTime</summary>
    public static class ClaimPredicateClaimPredicateBeforeAbsoluteTimeGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimPredicateClaimPredicateBeforeAbsoluteTimeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime
            if (!model.IsDefined(typeof(Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "absBefore");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimPredicate+ClaimPredicateBeforeAbsoluteTime</summary>
        public static readonly Marshaller<Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime> ClaimPredicate_ClaimPredicateBeforeAbsoluteTimeMarshaller = Marshallers.Create<Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime>(
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
                        return Serializer.Deserialize<Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
