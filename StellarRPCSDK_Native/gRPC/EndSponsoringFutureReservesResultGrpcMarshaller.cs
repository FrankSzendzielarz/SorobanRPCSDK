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
    /// <summary>Custom marshaller for Stellar.EndSponsoringFutureReservesResult</summary>
    public static class EndSponsoringFutureReservesResultGrpcMarshaller
    {
        // Static constructor to configure type
        static EndSponsoringFutureReservesResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.EndSponsoringFutureReservesResult
            if (!model.IsDefined(typeof(Stellar.EndSponsoringFutureReservesResult)))
            {
                var metaType = model.Add(typeof(Stellar.EndSponsoringFutureReservesResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesSuccess));
                metaType.AddSubType(101, typeof(Stellar.EndSponsoringFutureReservesResult.EndSponsoringFutureReservesNotSponsored));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EndSponsoringFutureReservesResult</summary>
        public static readonly Marshaller<Stellar.EndSponsoringFutureReservesResult> EndSponsoringFutureReservesResultMarshaller = Marshallers.Create<Stellar.EndSponsoringFutureReservesResult>(
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
                        return Serializer.Deserialize<Stellar.EndSponsoringFutureReservesResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
