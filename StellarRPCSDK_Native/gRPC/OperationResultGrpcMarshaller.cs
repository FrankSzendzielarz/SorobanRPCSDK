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
    /// <summary>Custom marshaller for Stellar.OperationResult</summary>
    public static class OperationResultGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult
            if (!model.IsDefined(typeof(Stellar.OperationResult)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.OperationResult.OpINNER));
                metaType.AddSubType(101, typeof(Stellar.OperationResult.OpbadAuth));
                metaType.AddSubType(102, typeof(Stellar.OperationResult.OpnoAccount));
                metaType.AddSubType(103, typeof(Stellar.OperationResult.OpnotSupported));
                metaType.AddSubType(104, typeof(Stellar.OperationResult.OptooManySubentries));
                metaType.AddSubType(105, typeof(Stellar.OperationResult.OpexceededWorkLimit));
                metaType.AddSubType(106, typeof(Stellar.OperationResult.OptooManySponsoring));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult</summary>
        public static readonly Marshaller<Stellar.OperationResult> OperationResultMarshaller = Marshallers.Create<Stellar.OperationResult>(
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
                        return Serializer.Deserialize<Stellar.OperationResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
