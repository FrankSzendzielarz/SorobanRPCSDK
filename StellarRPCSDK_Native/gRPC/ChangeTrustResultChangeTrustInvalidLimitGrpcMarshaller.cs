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
    /// <summary>Custom marshaller for Stellar.ChangeTrustResult+ChangeTrustInvalidLimit</summary>
    public static class ChangeTrustResultChangeTrustInvalidLimitGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustResultChangeTrustInvalidLimitGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustResult.ChangeTrustInvalidLimit
            if (!model.IsDefined(typeof(Stellar.ChangeTrustResult.ChangeTrustInvalidLimit)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustResult.ChangeTrustInvalidLimit), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustResult+ChangeTrustInvalidLimit</summary>
        public static readonly Marshaller<Stellar.ChangeTrustResult.ChangeTrustInvalidLimit> ChangeTrustResult_ChangeTrustInvalidLimitMarshaller = Marshallers.Create<Stellar.ChangeTrustResult.ChangeTrustInvalidLimit>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustResult.ChangeTrustInvalidLimit>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
