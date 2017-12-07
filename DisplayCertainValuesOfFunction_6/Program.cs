using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayCertainValuesOfFunction_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 6 Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5). 

            int x, y;

            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0} ; x=({0})² - 2*({0}) +1 = {1}", y, x);
            }

            /* int num1
            Console.WriteLine("Enter number ranging -5 to +5: ");
            num1 = int.Parse(Console.ReadLine());

            x = (num1 * 2) + (2 * num1) + 1;

            if (num1 > -5 && num1 <= 5)
            {
                Console.WriteLine("Result of function x = y² - 2y +1 is: ");
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Bad numbers!");
            }*/

            Console.ReadKey();
        }
    }
}
