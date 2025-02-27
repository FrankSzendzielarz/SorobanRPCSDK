// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.GetTransactionParams</summary>
    public static class GetTransactionParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static GetTransactionParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetTransactionParams
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionParams)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetTransactionParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Hash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GetTransactionParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionParams> GetTransactionParamsMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
