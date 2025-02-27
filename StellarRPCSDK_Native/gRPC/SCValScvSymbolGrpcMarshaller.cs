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
    /// <summary>Custom marshaller for Stellar.SCVal+ScvSymbol</summary>
    public static class SCValScvSymbolGrpcMarshaller
    {
        // Static constructor to configure type
        static SCValScvSymbolGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCVal.ScvSymbol
            if (!model.IsDefined(typeof(Stellar.SCVal.ScvSymbol)))
            {
                var metaType = model.Add(typeof(Stellar.SCVal.ScvSymbol), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(15, "sym");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCVal+ScvSymbol</summary>
        public static readonly Marshaller<Stellar.SCVal.ScvSymbol> SCVal_ScvSymbolMarshaller = Marshallers.Create<Stellar.SCVal.ScvSymbol>(
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
                        return Serializer.Deserialize<Stellar.SCVal.ScvSymbol>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
