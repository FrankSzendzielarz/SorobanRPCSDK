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
    /// <summary>Custom marshaller for Stellar.EndSponsoringFutureReservesResultEncodeRequest</summary>
    public static class EndSponsoringFutureReservesResultEncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static EndSponsoringFutureReservesResultEncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.EndSponsoringFutureReservesResultEncodeRequest
            if (!model.IsDefined(typeof(Stellar.EndSponsoringFutureReservesResultEncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.EndSponsoringFutureReservesResultEncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.EndSponsoringFutureReservesResultEncodeRequest</summary>
        public static readonly Marshaller<Stellar.EndSponsoringFutureReservesResultEncodeRequest> EndSponsoringFutureReservesResultEncodeRequestMarshaller = Marshallers.Create<Stellar.EndSponsoringFutureReservesResultEncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.EndSponsoringFutureReservesResultEncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
