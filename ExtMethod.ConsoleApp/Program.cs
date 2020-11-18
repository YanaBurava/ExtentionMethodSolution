using System;

namespace ExtHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            long word = 0b00001100;

            Console.WriteLine(Convert.ToString(word, 2));
            Console.WriteLine(word.GetBit(63));
            //for (int i = 0; i <= 31; ++i)
            //    Console.WriteLine(word.GetBit(i));
            Console.WriteLine(Convert.ToString(word.SetBit(1, 63), 2));
            //Console.WriteLine(word.GetBit(15));
            
        }
    }
}
