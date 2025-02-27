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
    /// <summary>Custom marshaller for Stellar.SCError</summary>
    public static class SCErrorGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError
            if (!model.IsDefined(typeof(Stellar.SCError)))
            {
                var metaType = model.Add(typeof(Stellar.SCError), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCError.SceContract));
                metaType.AddSubType(101, typeof(Stellar.SCError.SceWasmVm));
                metaType.AddSubType(102, typeof(Stellar.SCError.SceContext));
                metaType.AddSubType(103, typeof(Stellar.SCError.SceStorage));
                metaType.AddSubType(104, typeof(Stellar.SCError.SceObject));
                metaType.AddSubType(105, typeof(Stellar.SCError.SceCrypto));
                metaType.AddSubType(106, typeof(Stellar.SCError.SceEvents));
                metaType.AddSubType(107, typeof(Stellar.SCError.SceBudget));
                metaType.AddSubType(108, typeof(Stellar.SCError.SceValue));
                metaType.AddSubType(109, typeof(Stellar.SCError.SceAuth));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCError</summary>
        public static readonly Marshaller<Stellar.SCError> SCErrorMarshaller = Marshallers.Create<Stellar.SCError>(
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
                        return Serializer.Deserialize<Stellar.SCError>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
