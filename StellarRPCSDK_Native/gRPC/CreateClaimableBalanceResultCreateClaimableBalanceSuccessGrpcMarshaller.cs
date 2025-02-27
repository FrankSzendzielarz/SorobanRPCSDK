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
    /// <summary>Custom marshaller for Stellar.CreateClaimableBalanceResult+CreateClaimableBalanceSuccess</summary>
    public static class CreateClaimableBalanceResultCreateClaimableBalanceSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateClaimableBalanceResultCreateClaimableBalanceSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess
            if (!model.IsDefined(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "balanceID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateClaimableBalanceSuccess</summary>
        public static readonly Marshaller<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess> CreateClaimableBalanceSuccessMarshaller = Marshallers.Create<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess>(
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
                        return Serializer.Deserialize<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
