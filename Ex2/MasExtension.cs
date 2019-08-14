using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public static class MasExtension
    {
        public static string MasThroughSeparator(this int[] mas, string separator)
        {
            return string.Join(separator, mas);
        }
    }
}
