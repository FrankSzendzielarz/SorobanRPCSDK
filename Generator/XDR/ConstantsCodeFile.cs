using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.XDR
{
    internal class ConstantsCodeFile : CodeFile
    {
        public ConstantsCodeFile(string fileName, string indentString = "    ") : base(fileName, indentString)
        {
            AppendLine($"static class Constants");
            OpenBlock();

        }
    }
}
