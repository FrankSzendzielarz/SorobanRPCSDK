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
    /// <summary>Custom marshaller for Stellar.EndSponsoringFutureReservesResult+EndSponsoringFutureReservesSuccess</summary>
    public static class EndSponsoringFutureReservesResultEndSponsoringFutureReservesSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static EndSponsoringFutureReservesResultEndSponsoringFutureReservesSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess
            if (!model.IsDefined(typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.EndSponsoringFutureReservesResult+EndSponsoringFutureReservesSuccess</summary>
        public static readonly Marshaller<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess> EndSponsoringFutureReservesResult_EndSponsoringFutureReservesSuccessMarshaller = Marshallers.Create<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess>(
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
                        return Serializer.Deserialize<Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
