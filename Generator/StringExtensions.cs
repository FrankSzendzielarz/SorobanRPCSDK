using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string str) =>
            char.ToLowerInvariant(str[0]) + str.Substring(1);
        public static string ToPascalCase(this string str) =>
           char.ToUpperInvariant(str[0]) + str.Substring(1);
        public static string SplitPascalCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            // Add a space before any uppercase letters, then trim the leading space
            string result = System.Text.RegularExpressions.Regex.Replace(str, "([A-Z])", " $1").Trim();

            return result;
        }
        public static string SnakeToPascal(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            // If it's not snake case and not all uppercase, use default ToPascalCase
            if (!str.Contains('_') && !str.All(c => !char.IsLetter(c) || char.IsUpper(c)))
                return str.ToPascalCase();

            return string
                .Join(
                    string.Empty,
                    str.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(word => word.Length > 0
                            ? char.ToUpper(word[0]) + word.Substring(1).ToLower()
                            : word)
                );
        }

    }
}
