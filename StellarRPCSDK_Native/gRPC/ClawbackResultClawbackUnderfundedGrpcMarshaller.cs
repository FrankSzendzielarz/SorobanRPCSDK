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
    /// <summary>Custom marshaller for Stellar.ClawbackResult+ClawbackUnderfunded</summary>
    public static class ClawbackResultClawbackUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static ClawbackResultClawbackUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClawbackResult.ClawbackUnderfunded
            if (!model.IsDefined(typeof(Stellar.ClawbackResult.ClawbackUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.ClawbackResult.ClawbackUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClawbackUnderfunded</summary>
        public static readonly Marshaller<Stellar.ClawbackResult.ClawbackUnderfunded> ClawbackUnderfundedMarshaller = Marshallers.Create<Stellar.ClawbackResult.ClawbackUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.ClawbackResult.ClawbackUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
