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
    /// <summary>Custom marshaller for Stellar.RPC.SendTransactionParams</summary>
    public static class SendTransactionParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static SendTransactionParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.SendTransactionParams
            if (!model.IsDefined(typeof(Stellar.RPC.SendTransactionParams)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.SendTransactionParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Transaction");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SendTransactionParams</summary>
        public static readonly Marshaller<Stellar.RPC.SendTransactionParams> SendTransactionParamsMarshaller = Marshallers.Create<Stellar.RPC.SendTransactionParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.SendTransactionParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
