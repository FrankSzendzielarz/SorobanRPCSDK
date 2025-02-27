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
    /// <summary>Custom marshaller for Stellar.CreateClaimableBalanceResult+CreateClaimableBalanceUnderfunded</summary>
    public static class CreateClaimableBalanceResultCreateClaimableBalanceUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static CreateClaimableBalanceResultCreateClaimableBalanceUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded
            if (!model.IsDefined(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.CreateClaimableBalanceResult+CreateClaimableBalanceUnderfunded</summary>
        public static readonly Marshaller<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded> CreateClaimableBalanceResult_CreateClaimableBalanceUnderfundedMarshaller = Marshallers.Create<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.CreateClaimableBalanceResult.CreateClaimableBalanceUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
