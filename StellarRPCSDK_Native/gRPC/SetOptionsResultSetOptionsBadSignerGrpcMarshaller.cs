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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsBadSigner</summary>
    public static class SetOptionsResultSetOptionsBadSignerGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsBadSignerGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsBadSigner
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsBadSigner)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsBadSigner), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsBadSigner</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsBadSigner> SetOptionsResult_SetOptionsBadSignerMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsBadSigner>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsBadSigner>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
