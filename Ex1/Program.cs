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

            array.OutputMas();
        }
    }
}
