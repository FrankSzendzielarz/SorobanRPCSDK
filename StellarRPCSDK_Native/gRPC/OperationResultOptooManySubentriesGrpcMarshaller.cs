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
    /// <summary>Custom marshaller for Stellar.OperationResult+OptooManySubentries</summary>
    public static class OperationResultOptooManySubentriesGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResultOptooManySubentriesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.OptooManySubentries
            if (!model.IsDefined(typeof(Stellar.OperationResult.OptooManySubentries)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.OptooManySubentries), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for OptooManySubentries</summary>
        public static readonly Marshaller<Stellar.OperationResult.OptooManySubentries> OptooManySubentriesMarshaller = Marshallers.Create<Stellar.OperationResult.OptooManySubentries>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.OptooManySubentries>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
