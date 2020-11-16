using System;

namespace ExtHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0b10001100;

            Console.WriteLine(Convert.ToString(word, 2));
            Console.WriteLine(word.GetBits(1, 7));
            Console.WriteLine(Convert.ToString(word.SetBits(1, 1, 7), 2));
            Console.WriteLine(word.GetBits(1, 7));
            
        }
    }
}
