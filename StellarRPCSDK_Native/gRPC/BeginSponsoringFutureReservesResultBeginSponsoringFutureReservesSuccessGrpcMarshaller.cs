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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesResult+BeginSponsoringFutureReservesSuccess</summary>
    public static class BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BeginSponsoringFutureReservesSuccess</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess> BeginSponsoringFutureReservesSuccessMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
