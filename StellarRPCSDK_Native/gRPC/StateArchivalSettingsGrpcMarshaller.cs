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
    /// <summary>Custom marshaller for Stellar.StateArchivalSettings</summary>
    public static class StateArchivalSettingsGrpcMarshaller
    {
        // Static constructor to configure type
        static StateArchivalSettingsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StateArchivalSettings
            if (!model.IsDefined(typeof(Stellar.StateArchivalSettings)))
            {
                var metaType = model.Add(typeof(Stellar.StateArchivalSettings), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "maxEntryTTL");
                metaType.Add(2, "minTemporaryTTL");
                metaType.Add(3, "minPersistentTTL");
                metaType.Add(4, "persistentRentRateDenominator");
                metaType.Add(5, "tempRentRateDenominator");
                metaType.Add(6, "maxEntriesToArchive");
                metaType.Add(7, "bucketListSizeWindowSampleSize");
                metaType.Add(8, "bucketListWindowSamplePeriod");
                metaType.Add(9, "evictionScanSize");
                metaType.Add(10, "startingEvictionScanLevel");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for StateArchivalSettings</summary>
        public static readonly Marshaller<Stellar.StateArchivalSettings> StateArchivalSettingsMarshaller = Marshallers.Create<Stellar.StateArchivalSettings>(
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
                        return Serializer.Deserialize<Stellar.StateArchivalSettings>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
