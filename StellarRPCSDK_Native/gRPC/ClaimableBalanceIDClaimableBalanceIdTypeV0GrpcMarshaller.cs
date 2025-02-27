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
    /// <summary>Custom marshaller for Stellar.ClaimableBalanceID+ClaimableBalanceIdTypeV0</summary>
    public static class ClaimableBalanceIDClaimableBalanceIdTypeV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimableBalanceIDClaimableBalanceIdTypeV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0
            if (!model.IsDefined(typeof(Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "v0");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimableBalanceIdTypeV0</summary>
        public static readonly Marshaller<Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0> ClaimableBalanceIdTypeV0Marshaller = Marshallers.Create<Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0>(
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
                        return Serializer.Deserialize<Stellar.ClaimableBalanceID.ClaimableBalanceIdTypeV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
