using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions3
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkersanswer;

            Console.Write("Please give a number between 6 and 17: ");
            checkersanswer = numbercorrectness(6, 17);
            Console.Write("Input {0} is valid number.", checkersanswer);
            Console.ReadKey();
        }

        static string numbercorrectness(int lowerlimit, int upperlimit)
        {
            int checkablenumber = 0;
            string checkmessage = "0";
            bool correctnumber = false;

            do
            {
                string inputnumber = Console.ReadLine();               

                if (Int32.TryParse(inputnumber, out checkablenumber))
                {
                    // checking number range here
                    if (checkablenumber < lowerlimit | checkablenumber > upperlimit)
                    {
                        Console.Write("Input {0} is not a number between 6 and 17. Try again, please.", checkablenumber);                        
                    }
                    else
                    {
                        checkmessage = string.Format("{0}", checkablenumber); // correct input recieved -> allow continue
                        correctnumber = true;
                    }
                }
                else
                {
                    Console.Write("Input is not a valid number."); // not a number
                }
            } while (correctnumber == false);

            return checkmessage; // number ?
        }
    }
}
