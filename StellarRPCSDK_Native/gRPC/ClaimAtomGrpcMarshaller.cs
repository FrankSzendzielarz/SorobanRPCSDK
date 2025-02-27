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
    /// <summary>Custom marshaller for Stellar.ClaimAtom</summary>
    public static class ClaimAtomGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimAtomGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimAtom
            if (!model.IsDefined(typeof(Stellar.ClaimAtom)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimAtom), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ClaimAtom.ClaimAtomTypeV0));
                metaType.AddSubType(101, typeof(Stellar.ClaimAtom.ClaimAtomTypeOrderBook));
                metaType.AddSubType(102, typeof(Stellar.ClaimAtom.ClaimAtomTypeLiquidityPool));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ClaimAtom</summary>
        public static readonly Marshaller<Stellar.ClaimAtom> ClaimAtomMarshaller = Marshallers.Create<Stellar.ClaimAtom>(
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
                        return Serializer.Deserialize<Stellar.ClaimAtom>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
