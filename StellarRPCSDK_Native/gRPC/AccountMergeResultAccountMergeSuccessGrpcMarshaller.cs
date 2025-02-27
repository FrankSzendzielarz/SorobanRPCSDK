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
    /// <summary>Custom marshaller for Stellar.AccountMergeResult+AccountMergeSuccess</summary>
    public static class AccountMergeResultAccountMergeSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static AccountMergeResultAccountMergeSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AccountMergeResult.AccountMergeSuccess
            if (!model.IsDefined(typeof(Stellar.AccountMergeResult.AccountMergeSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.AccountMergeResult.AccountMergeSuccess), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sourceAccountBalance");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AccountMergeResult+AccountMergeSuccess</summary>
        public static readonly Marshaller<Stellar.AccountMergeResult.AccountMergeSuccess> AccountMergeResult_AccountMergeSuccessMarshaller = Marshallers.Create<Stellar.AccountMergeResult.AccountMergeSuccess>(
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
                        return Serializer.Deserialize<Stellar.AccountMergeResult.AccountMergeSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
