using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_PracticeDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 1 Write a C# Sharp program that takes three letters as input and display them in reverse order.

            string input1, input2, input3;

            Console.WriteLine("Enter first Letter: ");
            input1 = Console.ReadLine();

            Console.WriteLine("Enter second Letter: ");
            input2 = Console.ReadLine();

            Console.WriteLine("Enter tird Letter: ");
            input3 = Console.ReadLine();

            string[] str = { input1, input2, input3 };
            Array.Reverse(str);
            Console.WriteLine("\nReverse: {0}", string.Join(", ", str));
            Console.ReadLine();
        }
    }
}
