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
    /// <summary>Custom marshaller for Stellar.SCError+SceWasmVm</summary>
    public static class SCErrorSceWasmVmGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceWasmVmGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceWasmVm
            if (!model.IsDefined(typeof(Stellar.SCError.SceWasmVm)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceWasmVm), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCError+SceWasmVm</summary>
        public static readonly Marshaller<Stellar.SCError.SceWasmVm> SCError_SceWasmVmMarshaller = Marshallers.Create<Stellar.SCError.SceWasmVm>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceWasmVm>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
