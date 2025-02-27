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
    /// <summary>Custom marshaller for Stellar.BumpSequenceResult+BumpSequenceSuccess</summary>
    public static class BumpSequenceResultBumpSequenceSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static BumpSequenceResultBumpSequenceSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BumpSequenceResult.BumpSequenceSuccess
            if (!model.IsDefined(typeof(Stellar.BumpSequenceResult.BumpSequenceSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.BumpSequenceResult.BumpSequenceSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BumpSequenceResult+BumpSequenceSuccess</summary>
        public static readonly Marshaller<Stellar.BumpSequenceResult.BumpSequenceSuccess> BumpSequenceResult_BumpSequenceSuccessMarshaller = Marshallers.Create<Stellar.BumpSequenceResult.BumpSequenceSuccess>(
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
                        return Serializer.Deserialize<Stellar.BumpSequenceResult.BumpSequenceSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
