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
    /// <summary>Custom marshaller for Stellar.SCVal</summary>
    public static class SCValGrpcMarshaller
    {
        // Static constructor to configure type
        static SCValGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal
            if (!model.IsDefined(typeof(Stellar.SCVal)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCVal.ScvBool));
                metaType.AddSubType(101, typeof(Stellar.SCVal.ScvVoid));
                metaType.AddSubType(102, typeof(Stellar.SCVal.ScvError));
                metaType.AddSubType(103, typeof(Stellar.SCVal.ScvU32));
                metaType.AddSubType(104, typeof(Stellar.SCVal.ScvI32));
                metaType.AddSubType(105, typeof(Stellar.SCVal.ScvU64));
                metaType.AddSubType(106, typeof(Stellar.SCVal.ScvI64));
                metaType.AddSubType(107, typeof(Stellar.SCVal.ScvTimepoint));
                metaType.AddSubType(108, typeof(Stellar.SCVal.ScvDuration));
                metaType.AddSubType(109, typeof(Stellar.SCVal.ScvU128));
                metaType.AddSubType(110, typeof(Stellar.SCVal.ScvI128));
                metaType.AddSubType(111, typeof(Stellar.SCVal.ScvU256));
                metaType.AddSubType(112, typeof(Stellar.SCVal.ScvI256));
                metaType.AddSubType(113, typeof(Stellar.SCVal.ScvBytes));
                metaType.AddSubType(114, typeof(Stellar.SCVal.ScvString));
                metaType.AddSubType(115, typeof(Stellar.SCVal.ScvSymbol));
                metaType.AddSubType(116, typeof(Stellar.SCVal.ScvVec));
                metaType.AddSubType(117, typeof(Stellar.SCVal.ScvMap));
                metaType.AddSubType(118, typeof(Stellar.SCVal.ScvAddress));
                metaType.AddSubType(119, typeof(Stellar.SCVal.ScvLedgerKeyContractInstance));
                metaType.AddSubType(120, typeof(Stellar.SCVal.ScvLedgerKeyNonce));
                metaType.AddSubType(121, typeof(Stellar.SCVal.ScvContractInstance));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal</summary>
        public static readonly Marshaller<Stellar.SCVal> SCValMarshaller = Marshallers.Create<Stellar.SCVal>(
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
                        return Serializer.Deserialize<Stellar.SCVal>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
