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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsBadFlags</summary>
    public static class SetOptionsResultSetOptionsBadFlagsGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsBadFlagsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsBadFlags
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsBadFlags)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsBadFlags), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SetOptionsBadFlags</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsBadFlags> SetOptionsBadFlagsMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsBadFlags>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsBadFlags>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
