using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserIDAndPasswordAfter3WrongAttemptsRejected_3
{
    class Program
    {
        public static void Main()
        {
            // № 3 Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.

            string username, password;
            int ctr = 0, dd = 0;
            Console.Write("Defaule username and password is : user and pass\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "user" && password == "pass")
                {
                    dd = 1;
                    ctr = 3;
                }

                else
                {
                    dd = 0;
                    ctr++;
                }
            }
            while ((username != "user" || password != "pass") && (ctr != 3));

            if (dd == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else if (dd == 1)
            {
                Console.Write("\nSuccessfull!\n\n");
            }
            Console.ReadLine();
        }
    }
}
