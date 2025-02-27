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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef+ScSpecTypeSymbol</summary>
    public static class SCSpecTypeDefScSpecTypeSymbolGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefScSpecTypeSymbolGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef.ScSpecTypeSymbol
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef.ScSpecTypeSymbol)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef.ScSpecTypeSymbol), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ScSpecTypeSymbol</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef.ScSpecTypeSymbol> ScSpecTypeSymbolMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef.ScSpecTypeSymbol>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef.ScSpecTypeSymbol>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
