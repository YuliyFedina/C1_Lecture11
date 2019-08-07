using System;

namespace Ex1
{
    public static class MasExtension
    {
        public static void OutputMas(this int[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }

        public static string MasThroughSeparator(this int[] mas, string separator)
        {
            var result="";
            foreach (var item in mas)
            {
                result += ($"{item}{separator}");
            }

            return result;
        }
    }
}