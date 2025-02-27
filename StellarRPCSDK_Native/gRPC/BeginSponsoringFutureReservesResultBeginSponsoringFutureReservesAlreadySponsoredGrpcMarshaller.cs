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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesResult+BeginSponsoringFutureReservesAlreadySponsored</summary>
    public static class BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesAlreadySponsoredGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesAlreadySponsoredGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BeginSponsoringFutureReservesAlreadySponsored</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored> BeginSponsoringFutureReservesAlreadySponsoredMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
