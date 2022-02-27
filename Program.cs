using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("-------------------");
            Console.WriteLine("--Numero Extensao--");
            Console.WriteLine("-------------------");
            number  = Convert.ToInt32(Console.ReadLine());
            string numberText = number.ToWords();
            Console.Write(numberText);

        }
    }
}
