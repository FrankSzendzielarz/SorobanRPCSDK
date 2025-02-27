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
    /// <summary>Custom marshaller for Stellar.BeginSponsoringFutureReservesOp</summary>
    public static class BeginSponsoringFutureReservesOpGrpcMarshaller
    {
        // Static constructor to configure type
        static BeginSponsoringFutureReservesOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BeginSponsoringFutureReservesOp
            if (!model.IsDefined(typeof(Stellar.BeginSponsoringFutureReservesOp)))
            {
                var metaType = model.Add(typeof(Stellar.BeginSponsoringFutureReservesOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sponsoredID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BeginSponsoringFutureReservesOp</summary>
        public static readonly Marshaller<Stellar.BeginSponsoringFutureReservesOp> BeginSponsoringFutureReservesOpMarshaller = Marshallers.Create<Stellar.BeginSponsoringFutureReservesOp>(
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
                        return Serializer.Deserialize<Stellar.BeginSponsoringFutureReservesOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
