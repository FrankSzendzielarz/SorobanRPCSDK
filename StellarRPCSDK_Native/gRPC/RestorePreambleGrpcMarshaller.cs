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
    /// <summary>Custom marshaller for Stellar.RPC.RestorePreamble</summary>
    public static class RestorePreambleGrpcMarshaller
    {
        // Static constructor to configure type
        static RestorePreambleGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.RestorePreamble
            if (!model.IsDefined(typeof(Stellar.RPC.RestorePreamble)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.RestorePreamble), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "MinResourceFee");
                metaType.Add(2, "TransactionData");
                metaType.Add(100, "SorobanTransactionData");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for RestorePreamble</summary>
        public static readonly Marshaller<Stellar.RPC.RestorePreamble> RestorePreambleMarshaller = Marshallers.Create<Stellar.RPC.RestorePreamble>(
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
                        return Serializer.Deserialize<Stellar.RPC.RestorePreamble>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
