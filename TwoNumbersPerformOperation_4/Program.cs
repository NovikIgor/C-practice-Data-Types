using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersPerformOperation_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 4 Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation. 

            int num1, num2, input1, input2, input3, input4;
            string check1;

            Console.WriteLine("Your first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nYou entered numbers: {0} and {1}\n", num1, num2);
            Console.WriteLine("Choose only one operation:  +  -  *  /");

            check1 = Console.ReadLine();

            if (check1.Equals("+"))
            {
                input1 = num1 + num2;
                Console.WriteLine("Result: {0}", input1);
            }
            else if (check1.Equals("-"))
            {
                input2 = num1 - num2;
                Console.WriteLine("Result: {0}", input2);
            }
            else if (check1.Equals("*") || check1.Equals("x"))
            {
                input3 = num1 * num2;
                Console.WriteLine("Result: {0}", input3);
            }
            else if (check1.Equals("/"))
            {
                input4 = num1 / num2;
                Console.WriteLine("Result: {0}", input4);
            }
            
            input1 = num1 + num2;
            input2 = num1 - num2;
            input3 = num1 * num2;
            input4 = num1 / num2;
            Console.ReadLine();
        }
    }
}
