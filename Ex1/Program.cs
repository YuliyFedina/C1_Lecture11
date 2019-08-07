using System;

namespace Ex1
{
    class Program
    {
        static void Main()
        {
            //Написать метод-расширение для массива целых чисел, который выводит этот массив на консоль.
            var array = new int[10];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            MasExtension.OutputMas(array);

            //Написать метод-расширение для массива целых чисел,
            //который принимает как параметр строку-разделитель,
            //а возвращает строку, в которой содержатся все элементы массива перечисленные через указанный разделитель.

            string result = MasExtension.MasThroughSeparator(array, "|");
            Console.WriteLine(result);
        }

    }
}
