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
    /// <summary>Custom marshaller for Stellar.ClawbackResult</summary>
    public static class ClawbackResultGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackResult
            if (!model.IsDefined(typeof(Stellar.ClawbackResult)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ClawbackResult.ClawbackSuccess));
                metaType.AddSubType(101, typeof(Stellar.ClawbackResult.ClawbackMalformed));
                metaType.AddSubType(102, typeof(Stellar.ClawbackResult.ClawbackNotClawbackEnabled));
                metaType.AddSubType(103, typeof(Stellar.ClawbackResult.ClawbackNoTrust));
                metaType.AddSubType(104, typeof(Stellar.ClawbackResult.ClawbackUnderfunded));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackResult</summary>
        public static readonly Marshaller<Stellar.ClawbackResult> ClawbackResultMarshaller = Marshallers.Create<Stellar.ClawbackResult>(
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
                        return Serializer.Deserialize<Stellar.ClawbackResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
