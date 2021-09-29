using System;

namespace BDSA2020.Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri input)
        {
            return input.Scheme == Uri.UriSchemeHttps
            
        }
        public static int WordCount(this string word)
        {
            return word.Split(" ").Length;
        }
    }
}
