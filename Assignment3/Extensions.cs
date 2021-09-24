using System;

namespace BDSA2020.Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri input)
        {
            if(input.Scheme == Uri.UriSchemeHttps)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int WordCount(this string word)
        {
            return word.Split(" ").Length;
        }
    }
}
