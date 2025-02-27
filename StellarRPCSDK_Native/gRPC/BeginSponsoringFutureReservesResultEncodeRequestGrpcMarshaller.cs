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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesResultEncodeRequest</summary>
    public static class BeginSponsoringFutureReservesResultEncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesResultEncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesResultEncodeRequest
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesResultEncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesResultEncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BeginSponsoringFutureReservesResultEncodeRequest</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesResultEncodeRequest> BeginSponsoringFutureReservesResultEncodeRequestMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesResultEncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesResultEncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
