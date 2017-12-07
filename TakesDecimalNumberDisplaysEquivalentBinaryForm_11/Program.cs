using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesDecimalNumberDisplaysEquivalentBinaryForm_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 11 Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

            Console.Write("Input a Number to convert : ");
            int str = int.Parse(Console.ReadLine());
            int bin = int.Parse(Convert.ToString(str, 2)); //conversion occurs here 
            Console.WriteLine("Binary number is: {0}", bin);
            Console.ReadLine();
        }
    }
}
