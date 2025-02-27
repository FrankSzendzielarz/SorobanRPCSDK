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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesResult+BeginSponsoringFutureReservesRecursive</summary>
    public static class BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesRecursiveGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesResultBeginSponsoringFutureReservesRecursiveGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BeginSponsoringFutureReservesRecursive</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive> BeginSponsoringFutureReservesRecursiveMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesResult.BeginSponsoringFutureReservesRecursive>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
