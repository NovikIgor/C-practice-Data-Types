using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplaysTriangleOfInputNumber_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 2 Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.

            int num, width;

            Console.WriteLine("Enter a one number: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Input the desired width: ");
            width = int.Parse(Console.ReadLine());

            int height = width;

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
            Console.ReadLine();
        }
    }
}
