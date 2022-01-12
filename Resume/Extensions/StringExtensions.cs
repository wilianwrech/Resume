using System;

namespace Resume.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// https://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-with-maximum-performance
        /// </summary>
        public static string FirstCharToUpper(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => input,
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };
    }
}