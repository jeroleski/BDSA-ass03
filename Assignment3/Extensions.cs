using System;
using System.Linq;
using System.Collections.Generic;

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
    }
}
