using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lab = true;
            while (lab)
            {


                Console.WriteLine("This is Lab 2");
                decimal length;
                decimal width;

                Console.WriteLine("please enter your Length");
                length = decimal.Parse(Console.ReadLine());
                Console.WriteLine("please enter a Width");
                width = decimal.Parse(Console.ReadLine());


                decimal area = length * width;
                decimal primeter = (2 * length) + (2 * width);

                Console.WriteLine($"Your Area is {area}");
                Console.WriteLine($"Your primeter is {primeter}");

                Console.WriteLine("Would you like to try again? Type Y or N.");
                string userResponse = Console.ReadLine();
                Console.WriteLine("Would you like to continue?");
                String Choice = Console.ReadLine();
                if (Choice == "n")
                {
                    lab = false;
                }
            }

           
        }
    }
}
