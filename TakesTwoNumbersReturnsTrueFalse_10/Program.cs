using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesTwoNumbersReturnsTrueFalse_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 10 Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.

            int s, z;

            Console.WriteLine("First number: ");
            s = int.Parse(Console.ReadLine());

            Console.WriteLine("First number: ");
            z = int.Parse(Console.ReadLine());

            if (s % 2 != 0 && z % 2 != 0)
            {
                Console.Write("Is a numbers odd? ");
                Console.WriteLine(true);
            }
            else
            {
                Console.Write("Is a numbers odd? ");
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }
    }
}
