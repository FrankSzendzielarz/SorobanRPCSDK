using System;
using System.Collections.Generic;
using System.Text;

namespace Stellar
{
    public partial class SequenceNumber
    {
        public SequenceNumber Increment()
        {
            InnerValue++;
            return this;
        }
    }
}
