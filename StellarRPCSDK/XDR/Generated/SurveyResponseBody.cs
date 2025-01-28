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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SurveyResponseBody
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V0 : SurveyResponseBody
    {
        public override int Discriminator => SURVEY_TOPOLOGY_RESPONSE_V0;
        private TopologyResponseBodyV0 _topologyResponseBodyV0;
        public TopologyResponseBodyV0 topologyResponseBodyV0
        {
            get => _topologyResponseBodyV0;
            set
            {
                _topologyResponseBodyV0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V1 : SurveyResponseBody
    {
        public override int Discriminator => SURVEY_TOPOLOGY_RESPONSE_V1;
        private TopologyResponseBodyV1 _topologyResponseBodyV1;
        public TopologyResponseBodyV1 topologyResponseBodyV1
        {
            get => _topologyResponseBodyV1;
            set
            {
                _topologyResponseBodyV1 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V2 : SurveyResponseBody
    {
        public override int Discriminator => SURVEY_TOPOLOGY_RESPONSE_V2;
        private TopologyResponseBodyV2 _topologyResponseBodyV2;
        public TopologyResponseBodyV2 topologyResponseBodyV2
        {
            get => _topologyResponseBodyV2;
            set
            {
                _topologyResponseBodyV2 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SurveyResponseBodyXdr
    {
        public static void Encode(XdrWriter stream, SurveyResponseBody value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V0 case_SURVEY_TOPOLOGY_RESPONSE_V0:
                TopologyResponseBodyV0Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V0.topologyResponseBodyV0);
                break;
                case SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V1 case_SURVEY_TOPOLOGY_RESPONSE_V1:
                TopologyResponseBodyV1Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V1.topologyResponseBodyV1);
                break;
                case SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V2 case_SURVEY_TOPOLOGY_RESPONSE_V2:
                TopologyResponseBodyV2Xdr.Encode(stream, case_SURVEY_TOPOLOGY_RESPONSE_V2.topologyResponseBodyV2);
                break;
            }
        }
        public static SurveyResponseBody Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case SURVEY_TOPOLOGY_RESPONSE_V0:
                var result_SURVEY_TOPOLOGY_RESPONSE_V0 = new SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V0();
                result_SURVEY_TOPOLOGY_RESPONSE_V0.                 = TopologyResponseBodyV0Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V0;
                case SURVEY_TOPOLOGY_RESPONSE_V1:
                var result_SURVEY_TOPOLOGY_RESPONSE_V1 = new SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V1();
                result_SURVEY_TOPOLOGY_RESPONSE_V1.                 = TopologyResponseBodyV1Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V1;
                case SURVEY_TOPOLOGY_RESPONSE_V2:
                var result_SURVEY_TOPOLOGY_RESPONSE_V2 = new SurveyResponseBody_SURVEY_TOPOLOGY_RESPONSE_V2();
                result_SURVEY_TOPOLOGY_RESPONSE_V2.                 = TopologyResponseBodyV2Xdr.Decode(stream);
                return result_SURVEY_TOPOLOGY_RESPONSE_V2;
                default:
                throw new Exception($"Unknown discriminator for SurveyResponseBody: {discriminator}");
            }
        }
    }
}
