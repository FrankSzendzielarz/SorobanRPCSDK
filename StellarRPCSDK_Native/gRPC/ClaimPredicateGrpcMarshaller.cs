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
    /// <summary>Custom marshaller for Stellar.ClaimPredicate</summary>
    public static class ClaimPredicateGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimPredicateGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimPredicate
            if (!model.IsDefined(typeof(Stellar.ClaimPredicate)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimPredicate), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ClaimPredicate.ClaimPredicateUnconditional));
                metaType.AddSubType(101, typeof(Stellar.ClaimPredicate.ClaimPredicateAnd));
                metaType.AddSubType(102, typeof(Stellar.ClaimPredicate.ClaimPredicateOr));
                metaType.AddSubType(103, typeof(Stellar.ClaimPredicate.ClaimPredicateNot));
                metaType.AddSubType(104, typeof(Stellar.ClaimPredicate.ClaimPredicateBeforeAbsoluteTime));
                metaType.AddSubType(105, typeof(Stellar.ClaimPredicate.ClaimPredicateBeforeRelativeTime));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimPredicate</summary>
        public static readonly Marshaller<Stellar.ClaimPredicate> ClaimPredicateMarshaller = Marshallers.Create<Stellar.ClaimPredicate>(
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
                        return Serializer.Deserialize<Stellar.ClaimPredicate>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
