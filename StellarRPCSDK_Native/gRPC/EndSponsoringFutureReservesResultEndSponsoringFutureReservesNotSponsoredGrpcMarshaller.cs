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
    /// <summary>Custom marshaller for Stellar.EndSponsoringFutureReservesResult+EndSponsoringFutureReservesNotSponsored</summary>
    public static class EndSponsoringFutureReservesResultEndSponsoringFutureReservesNotSponsoredGrpcMarshaller
    {
        // Static constructor to configure type
        static EndSponsoringFutureReservesResultEndSponsoringFutureReservesNotSponsoredGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored
            if (!model.IsDefined(typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored)))
            {
                var metaType = model.Add(typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EndSponsoringFutureReservesNotSponsored</summary>
        public static readonly Marshaller<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored> EndSponsoringFutureReservesNotSponsoredMarshaller = Marshallers.Create<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored>(
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
                        return Serializer.Deserialize<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
