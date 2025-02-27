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
    /// <summary>Custom marshaller for Stellar.AccountMergeResult+AccountMergeSeqnumTooFar</summary>
    public static class AccountMergeResultAccountMergeSeqnumTooFarGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountMergeResultAccountMergeSeqnumTooFarGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountMergeResult.AccountMergeSeqnumTooFar
            if (!model.IsDefined(typeof(Stellar.AccountMergeResult.AccountMergeSeqnumTooFar)))
            {
                var metaType = model.Add(typeof(Stellar.AccountMergeResult.AccountMergeSeqnumTooFar), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AccountMergeResult+AccountMergeSeqnumTooFar</summary>
        public static readonly Marshaller<Stellar.AccountMergeResult.AccountMergeSeqnumTooFar> AccountMergeResult_AccountMergeSeqnumTooFarMarshaller = Marshallers.Create<Stellar.AccountMergeResult.AccountMergeSeqnumTooFar>(
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
                        return Serializer.Deserialize<Stellar.AccountMergeResult.AccountMergeSeqnumTooFar>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
