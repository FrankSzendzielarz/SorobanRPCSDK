using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKTest
{
    public class TestCase
    {
        public string TypeName { get; set; }
        public string FirstXdrBase64 { get; set; }
        public string SecondXdrBase64 { get; set; }
        public bool Success { get; set; }
    }
}
