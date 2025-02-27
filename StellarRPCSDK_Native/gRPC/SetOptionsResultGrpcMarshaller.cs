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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult</summary>
    public static class SetOptionsResultGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SetOptionsResult.SetOptionsSuccess));
                metaType.AddSubType(101, typeof(Stellar.SetOptionsResult.SetOptionsLowReserve));
                metaType.AddSubType(102, typeof(Stellar.SetOptionsResult.SetOptionsTooManySigners));
                metaType.AddSubType(103, typeof(Stellar.SetOptionsResult.SetOptionsBadFlags));
                metaType.AddSubType(104, typeof(Stellar.SetOptionsResult.SetOptionsInvalidInflation));
                metaType.AddSubType(105, typeof(Stellar.SetOptionsResult.SetOptionsCantChange));
                metaType.AddSubType(106, typeof(Stellar.SetOptionsResult.SetOptionsUnknownFlag));
                metaType.AddSubType(107, typeof(Stellar.SetOptionsResult.SetOptionsThresholdOutOfRange));
                metaType.AddSubType(108, typeof(Stellar.SetOptionsResult.SetOptionsBadSigner));
                metaType.AddSubType(109, typeof(Stellar.SetOptionsResult.SetOptionsInvalidHomeDomain));
                metaType.AddSubType(110, typeof(Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult> SetOptionsResultMarshaller = Marshallers.Create<Stellar.SetOptionsResult>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
