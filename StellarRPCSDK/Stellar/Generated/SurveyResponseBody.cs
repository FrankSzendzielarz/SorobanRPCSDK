// Generated code - do not modify
// Source:

// union SurveyResponseBody switch (SurveyMessageResponseType type)
// {
// case SURVEY_TOPOLOGY_RESPONSE_V0:
//     TopologyResponseBodyV0 topologyResponseBodyV0;
// case SURVEY_TOPOLOGY_RESPONSE_V1:
//     TopologyResponseBodyV1 topologyResponseBodyV1;
// case SURVEY_TOPOLOGY_RESPONSE_V2:
//     TopologyResponseBodyV2 topologyResponseBodyV2;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class SurveyResponseBody
    {
        public abstract SurveyMessageResponseType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class SurveyTopologyResponseV0 : SurveyResponseBody
        {
            public override SurveyMessageResponseType Discriminator => SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V0;
            public TopologyResponseBodyV0 topologyResponseBodyV0
            {
                get => _topologyResponseBodyV0;
                set
                {
                    _topologyResponseBodyV0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Topology Response Body V0")]
            #endif
            private TopologyResponseBodyV0 _topologyResponseBodyV0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SurveyTopologyResponseV1 : SurveyResponseBody
        {
            public override SurveyMessageResponseType Discriminator => SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V1;
            public TopologyResponseBodyV1 topologyResponseBodyV1
            {
                get => _topologyResponseBodyV1;
                set
                {
                    _topologyResponseBodyV1 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Topology Response Body V1")]
            #endif
            private TopologyResponseBodyV1 _topologyResponseBodyV1;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SurveyTopologyResponseV2 : SurveyResponseBody
        {
            public override SurveyMessageResponseType Discriminator => SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V2;
            public TopologyResponseBodyV2 topologyResponseBodyV2
            {
                get => _topologyResponseBodyV2;
                set
                {
                    _topologyResponseBodyV2 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Topology Response Body V2")]
            #endif
            private TopologyResponseBodyV2 _topologyResponseBodyV2;

            public override void ValidateCase() {}
        }
    }
    public static partial class SurveyResponseBodyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SurveyResponseBody value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SurveyResponseBodyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SurveyResponseBody value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SurveyResponseBody.SurveyTopologyResponseV0 case_SURVEY_TOPOLOGY_RESPONSE_V0:
                TopologyResponseBodyV0Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V0.topologyResponseBodyV0);
                break;
                case SurveyResponseBody.SurveyTopologyResponseV1 case_SURVEY_TOPOLOGY_RESPONSE_V1:
                TopologyResponseBodyV1Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V1.topologyResponseBodyV1);
                break;
                case SurveyResponseBody.SurveyTopologyResponseV2 case_SURVEY_TOPOLOGY_RESPONSE_V2:
                TopologyResponseBodyV2Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V2.topologyResponseBodyV2);
                break;
            }
        }
        public static SurveyResponseBody Decode(XdrReader stream)
        {
            var discriminator = (SurveyMessageResponseType)stream.ReadInt();
            switch (discriminator)
            {
                case SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V0:
                var result_SURVEY_TOPOLOGY_RESPONSE_V0 = new SurveyResponseBody.SurveyTopologyResponseV0();
                result_SURVEY_TOPOLOGY_RESPONSE_V0.topologyResponseBodyV0 = TopologyResponseBodyV0Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V0;
                case SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V1:
                var result_SURVEY_TOPOLOGY_RESPONSE_V1 = new SurveyResponseBody.SurveyTopologyResponseV1();
                result_SURVEY_TOPOLOGY_RESPONSE_V1.topologyResponseBodyV1 = TopologyResponseBodyV1Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V1;
                case SurveyMessageResponseType.SURVEY_TOPOLOGY_RESPONSE_V2:
                var result_SURVEY_TOPOLOGY_RESPONSE_V2 = new SurveyResponseBody.SurveyTopologyResponseV2();
                result_SURVEY_TOPOLOGY_RESPONSE_V2.topologyResponseBodyV2 = TopologyResponseBodyV2Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V2;
                default:
                throw new Exception($"Unknown discriminator for SurveyResponseBody: {discriminator}");
            }
        }
    }
}
