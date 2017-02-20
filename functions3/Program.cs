using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions3
{
    class Program
    {
        static string numbercorrectness(int inputnumber)
        {
            int checkit = inputnumber;
            string checkmessage = string.Empty;
            int inputnumber = int.TryParse(Console.ReadLine(), out inputnumber);
            if (!inputnumber) // incorrect input
            {
                Console.Write("Input is NOT a number.");
            }
            else
            if (inputnumber < 6 | inputnumber > 17)
            {
                checkmessage = ""
            }
            return checkmessage;

        }

            static void Main(string[] args)
        {
            int inputnumber = 0;
            //string message = string.Empty;


            Console.Write("Please give a number between 6 and 17: ");
            Console.ReadLine(numbercorrectness(inputnumber)); // Calls and prints

            Console.ReadKey();
        }
    }
}
