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
    /// <summary>Custom marshaller for Stellar.CreateClaimableBalanceResult+CreateClaimableBalanceMalformed</summary>
    public static class CreateClaimableBalanceResultCreateClaimableBalanceMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateClaimableBalanceResultCreateClaimableBalanceMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed
            if (!model.IsDefined(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for CreateClaimableBalanceMalformed</summary>
        public static readonly Marshaller<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed> CreateClaimableBalanceMalformedMarshaller = Marshallers.Create<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed>(
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
                        return Serializer.Deserialize<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
