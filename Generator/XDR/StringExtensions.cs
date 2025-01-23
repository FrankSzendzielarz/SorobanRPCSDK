using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.XDR
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string str) =>
            char.ToLowerInvariant(str[0]) + str.Substring(1);
    }
}
