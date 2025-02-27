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
    /// <summary>Custom marshaller for Stellar.OperationResult+OptooManySponsoring</summary>
    public static class OperationResultOptooManySponsoringGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResultOptooManySponsoringGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.OptooManySponsoring
            if (!model.IsDefined(typeof(Stellar.OperationResult.OptooManySponsoring)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.OptooManySponsoring), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for OptooManySponsoring</summary>
        public static readonly Marshaller<Stellar.OperationResult.OptooManySponsoring> OptooManySponsoringMarshaller = Marshallers.Create<Stellar.OperationResult.OptooManySponsoring>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.OptooManySponsoring>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
