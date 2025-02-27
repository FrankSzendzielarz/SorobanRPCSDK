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
    /// <summary>Custom marshaller for Stellar.AccountMergeResult</summary>
    public static class AccountMergeResultGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountMergeResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountMergeResult
            if (!model.IsDefined(typeof(Stellar.AccountMergeResult)))
            {
                var metaType = model.Add(typeof(Stellar.AccountMergeResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.AccountMergeResult.AccountMergeSuccess));
                metaType.AddSubType(101, typeof(Stellar.AccountMergeResult.AccountMergeMalformed));
                metaType.AddSubType(102, typeof(Stellar.AccountMergeResult.AccountMergeNoAccount));
                metaType.AddSubType(103, typeof(Stellar.AccountMergeResult.AccountMergeImmutableSet));
                metaType.AddSubType(104, typeof(Stellar.AccountMergeResult.AccountMergeHasSubEntries));
                metaType.AddSubType(105, typeof(Stellar.AccountMergeResult.AccountMergeSeqnumTooFar));
                metaType.AddSubType(106, typeof(Stellar.AccountMergeResult.AccountMergeDestFull));
                metaType.AddSubType(107, typeof(Stellar.AccountMergeResult.AccountMergeIsSponsor));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AccountMergeResult</summary>
        public static readonly Marshaller<Stellar.AccountMergeResult> AccountMergeResultMarshaller = Marshallers.Create<Stellar.AccountMergeResult>(
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
                        return Serializer.Deserialize<Stellar.AccountMergeResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
