using System;

namespace Ex2
{
    class Program
    {
        static void Main()
        {
            //Написать метод-расширение для массива целых чисел,
            //который принимает как параметр строку-разделитель,
            //а возвращает строку, в которой содержатся все элементы массива перечисленные через указанный разделитель.

            var array = new int[10];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            var result = MasExtension.MasThroughSeparator(array, "|");
            Console.WriteLine(result);
        }
    }
}
