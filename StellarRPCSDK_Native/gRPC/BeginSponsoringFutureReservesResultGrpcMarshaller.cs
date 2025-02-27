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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesResult</summary>
    public static class BeginSponsoringFutureReservesResultGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesResult
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesResult)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesSuccess));
                metaType.AddSubType(101, typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesMalformed));
                metaType.AddSubType(102, typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesAlreadySponsored));
                metaType.AddSubType(103, typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BeginSponsoringFutureReservesResult</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesResult> BeginSponsoringFutureReservesResultMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesResult>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
