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
    /// <summary>Custom marshaller for Stellar.LedgerKey</summary>
    public static class LedgerKeyGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey
            if (!model.IsDefined(typeof(Stellar.LedgerKey)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LedgerKey.Account));
                metaType.AddSubType(101, typeof(Stellar.LedgerKey.Trustline));
                metaType.AddSubType(102, typeof(Stellar.LedgerKey.Offer));
                metaType.AddSubType(103, typeof(Stellar.LedgerKey.Data));
                metaType.AddSubType(104, typeof(Stellar.LedgerKey.ClaimableBalance));
                metaType.AddSubType(105, typeof(Stellar.LedgerKey.LiquidityPool));
                metaType.AddSubType(106, typeof(Stellar.LedgerKey.ContractData));
                metaType.AddSubType(107, typeof(Stellar.LedgerKey.ContractCode));
                metaType.AddSubType(108, typeof(Stellar.LedgerKey.ConfigSetting));
                metaType.AddSubType(109, typeof(Stellar.LedgerKey.Ttl));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LedgerKey</summary>
        public static readonly Marshaller<Stellar.LedgerKey> LedgerKeyMarshaller = Marshallers.Create<Stellar.LedgerKey>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
