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
    /// <summary>Custom marshaller for Stellar.CreateClaimableBalanceResult+CreateClaimableBalanceNotAuthorized</summary>
    public static class CreateClaimableBalanceResultCreateClaimableBalanceNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateClaimableBalanceResultCreateClaimableBalanceNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized
            if (!model.IsDefined(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateClaimableBalanceNotAuthorized</summary>
        public static readonly Marshaller<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized> CreateClaimableBalanceNotAuthorizedMarshaller = Marshallers.Create<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
