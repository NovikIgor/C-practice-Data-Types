using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesRadiusOfCircleCalculatePerimeterAndArea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 5 Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.

            int num1, num2 = 2;
            float num3 = 3.14f, res;
            Console.WriteLine("Your first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter of Circle (spesial formula) : {0} * {1} * {2}", num2, num3, num1);
            res = num2 * num3 * num1;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
