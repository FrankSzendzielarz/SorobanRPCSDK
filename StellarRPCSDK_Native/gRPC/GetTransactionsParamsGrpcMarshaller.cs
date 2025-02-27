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
    /// <summary>Custom marshaller for Stellar.RPC.GetTransactionsParams</summary>
    public static class GetTransactionsParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static GetTransactionsParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetTransactionsParams
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionsParams)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetTransactionsParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "StartLedger");
                metaType.Add(2, "Pagination");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetTransactionsParams</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionsParams> GetTransactionsParamsMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionsParams>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionsParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
