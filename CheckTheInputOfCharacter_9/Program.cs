using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheInputOfCharacter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 9 Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.

            char symbol;

            Console.Write("Input one symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else if ((symbol == 'A') || (symbol == 'E') || (symbol == 'I') || (symbol == 'O') || (symbol == 'U'))
            {
                Console.WriteLine("It's a upperercase vowel.");
            }
            else
            {
                Console.Write("It's another symbol.");
            }

            Console.ReadLine();
        }
    }
}
