using System;
using System.Linq;

namespace CateringBackend.Utilities.Extensions
{
    public static class StringExtension
    {
        public static string[] SplitByCommaToArray (this string s)
        {
            return s.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToArray();
        }
    }
}
