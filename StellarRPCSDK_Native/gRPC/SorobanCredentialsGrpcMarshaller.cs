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
    /// <summary>Custom marshaller for Stellar.SorobanCredentials</summary>
    public static class SorobanCredentialsGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanCredentialsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanCredentials
            if (!model.IsDefined(typeof(Stellar.SorobanCredentials)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanCredentials), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SorobanCredentials.SorobanCredentialsSourceAccount));
                metaType.AddSubType(101, typeof(Stellar.SorobanCredentials.SorobanCredentialsAddress));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanCredentials</summary>
        public static readonly Marshaller<Stellar.SorobanCredentials> SorobanCredentialsMarshaller = Marshallers.Create<Stellar.SorobanCredentials>(
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
                        return Serializer.Deserialize<Stellar.SorobanCredentials>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
