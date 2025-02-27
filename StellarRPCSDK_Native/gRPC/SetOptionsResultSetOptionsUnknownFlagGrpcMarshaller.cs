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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsUnknownFlag</summary>
    public static class SetOptionsResultSetOptionsUnknownFlagGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsUnknownFlagGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsUnknownFlag
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsUnknownFlag)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsUnknownFlag), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsUnknownFlag</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsUnknownFlag> SetOptionsResult_SetOptionsUnknownFlagMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsUnknownFlag>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsUnknownFlag>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
