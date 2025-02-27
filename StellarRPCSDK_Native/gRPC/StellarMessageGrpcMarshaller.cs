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
    /// <summary>Custom marshaller for Stellar.StellarMessage</summary>
    public static class StellarMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage
            if (!model.IsDefined(typeof(Stellar.StellarMessage)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.StellarMessage.ErrorMsg));
                metaType.AddSubType(101, typeof(Stellar.StellarMessage.HelloCase));
                metaType.AddSubType(102, typeof(Stellar.StellarMessage.AuthCase));
                metaType.AddSubType(103, typeof(Stellar.StellarMessage.DontHaveCase));
                metaType.AddSubType(104, typeof(Stellar.StellarMessage.Peers));
                metaType.AddSubType(105, typeof(Stellar.StellarMessage.GetTxSet));
                metaType.AddSubType(106, typeof(Stellar.StellarMessage.TxSet));
                metaType.AddSubType(107, typeof(Stellar.StellarMessage.GeneralizedTxSet));
                metaType.AddSubType(108, typeof(Stellar.StellarMessage.TransactionCase));
                metaType.AddSubType(109, typeof(Stellar.StellarMessage.SurveyRequest));
                metaType.AddSubType(110, typeof(Stellar.StellarMessage.SurveyResponse));
                metaType.AddSubType(111, typeof(Stellar.StellarMessage.TimeSlicedSurveyRequest));
                metaType.AddSubType(112, typeof(Stellar.StellarMessage.TimeSlicedSurveyResponse));
                metaType.AddSubType(113, typeof(Stellar.StellarMessage.TimeSlicedSurveyStartCollecting));
                metaType.AddSubType(114, typeof(Stellar.StellarMessage.TimeSlicedSurveyStopCollecting));
                metaType.AddSubType(115, typeof(Stellar.StellarMessage.GetScpQuorumset));
                metaType.AddSubType(116, typeof(Stellar.StellarMessage.ScpQuorumset));
                metaType.AddSubType(117, typeof(Stellar.StellarMessage.ScpMessage));
                metaType.AddSubType(118, typeof(Stellar.StellarMessage.GetScpState));
                metaType.AddSubType(119, typeof(Stellar.StellarMessage.SendMoreCase));
                metaType.AddSubType(120, typeof(Stellar.StellarMessage.SendMoreExtendedCase));
                metaType.AddSubType(121, typeof(Stellar.StellarMessage.FloodAdvertCase));
                metaType.AddSubType(122, typeof(Stellar.StellarMessage.FloodDemandCase));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarMessage</summary>
        public static readonly Marshaller<Stellar.StellarMessage> StellarMessageMarshaller = Marshallers.Create<Stellar.StellarMessage>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
