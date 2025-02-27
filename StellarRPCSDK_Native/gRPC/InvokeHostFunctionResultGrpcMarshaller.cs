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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResult</summary>
    public static class InvokeHostFunctionResultGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResult
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResult)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionSuccess));
                metaType.AddSubType(101, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed));
                metaType.AddSubType(102, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionTrapped));
                metaType.AddSubType(103, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded));
                metaType.AddSubType(104, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived));
                metaType.AddSubType(105, typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionInsufficientRefundableFee));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InvokeHostFunctionResult</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResult> InvokeHostFunctionResultMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResult>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
