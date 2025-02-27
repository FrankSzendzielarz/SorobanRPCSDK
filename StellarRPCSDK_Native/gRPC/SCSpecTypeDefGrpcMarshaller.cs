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
    /// <summary>Custom marshaller for Stellar.SCSpecTypeDef</summary>
    public static class SCSpecTypeDefGrpcMarshaller
    {
        // Static constructor to configure type
        static SCSpecTypeDefGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCSpecTypeDef
            if (!model.IsDefined(typeof(Stellar.SCSpecTypeDef)))
            {
                var metaType = model.Add(typeof(Stellar.SCSpecTypeDef), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SCSpecTypeDef.ScSpecTypeVal));
                metaType.AddSubType(101, typeof(Stellar.SCSpecTypeDef.ScSpecTypeBool));
                metaType.AddSubType(102, typeof(Stellar.SCSpecTypeDef.ScSpecTypeVoid));
                metaType.AddSubType(103, typeof(Stellar.SCSpecTypeDef.ScSpecTypeError));
                metaType.AddSubType(104, typeof(Stellar.SCSpecTypeDef.ScSpecTypeU32));
                metaType.AddSubType(105, typeof(Stellar.SCSpecTypeDef.ScSpecTypeI32));
                metaType.AddSubType(106, typeof(Stellar.SCSpecTypeDef.ScSpecTypeU64));
                metaType.AddSubType(107, typeof(Stellar.SCSpecTypeDef.ScSpecTypeI64));
                metaType.AddSubType(108, typeof(Stellar.SCSpecTypeDef.ScSpecTypeTimepoint));
                metaType.AddSubType(109, typeof(Stellar.SCSpecTypeDef.ScSpecTypeDuration));
                metaType.AddSubType(110, typeof(Stellar.SCSpecTypeDef.ScSpecTypeU128));
                metaType.AddSubType(111, typeof(Stellar.SCSpecTypeDef.ScSpecTypeI128));
                metaType.AddSubType(112, typeof(Stellar.SCSpecTypeDef.ScSpecTypeU256));
                metaType.AddSubType(113, typeof(Stellar.SCSpecTypeDef.ScSpecTypeI256));
                metaType.AddSubType(114, typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytes));
                metaType.AddSubType(115, typeof(Stellar.SCSpecTypeDef.ScSpecTypeString));
                metaType.AddSubType(116, typeof(Stellar.SCSpecTypeDef.ScSpecTypeSymbol));
                metaType.AddSubType(117, typeof(Stellar.SCSpecTypeDef.ScSpecTypeAddress));
                metaType.AddSubType(118, typeof(Stellar.SCSpecTypeDef.ScSpecTypeOption));
                metaType.AddSubType(119, typeof(Stellar.SCSpecTypeDef.ScSpecTypeResult));
                metaType.AddSubType(120, typeof(Stellar.SCSpecTypeDef.ScSpecTypeVec));
                metaType.AddSubType(121, typeof(Stellar.SCSpecTypeDef.ScSpecTypeMap));
                metaType.AddSubType(122, typeof(Stellar.SCSpecTypeDef.ScSpecTypeTuple));
                metaType.AddSubType(123, typeof(Stellar.SCSpecTypeDef.ScSpecTypeBytesN));
                metaType.AddSubType(124, typeof(Stellar.SCSpecTypeDef.ScSpecTypeUdt));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SCSpecTypeDef</summary>
        public static readonly Marshaller<Stellar.SCSpecTypeDef> SCSpecTypeDefMarshaller = Marshallers.Create<Stellar.SCSpecTypeDef>(
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
                        return Serializer.Deserialize<Stellar.SCSpecTypeDef>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
