using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRadiusOfSphereAndDisplayTheSurfaceAndVolume_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 8 Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.

            int radius;
            double surface, x, y;
            float pi = 3.1415926535f;

            Console.Write("Input radius: ");
            radius = int.Parse(Console.ReadLine());

            x = radius * radius * radius;
            y = radius * radius;

            surface = 4 * pi * y;
            Console.WriteLine("Surface is: {0}", surface);

            double volume = 4f / 3f * pi * (x); // Why f - in the end of numbers 4 and 3?
            Console.WriteLine("Volume is: {0}", volume);


            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
