using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stellar
{
    [ProtoContract]
    public class StringWrapper
    {
        [ProtoMember(1)]
        public string Value { get; set; }
    }

    [ProtoContract]
    public class ByteArrayWrapper
    {
        [ProtoMember(1)]
        public byte[] Value { get; set; }
    }

    [ProtoContract]
    public class BoolWrapper
    {
        [ProtoMember(1)]
        public bool Value { get; set; }
    }
}
