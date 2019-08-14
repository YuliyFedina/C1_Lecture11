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
    }
}