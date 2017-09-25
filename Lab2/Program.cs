using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("please enter an integer between 1 and 100:");
            int a = int.Parse(Console.ReadLine());

            //if integer is odd

            if (a % 2 != 0)
            {
                Console.WriteLine("Odd");
            }
            else if ((a % 2 == 0) && (a <= 25))
            {
                Console.WriteLine("Even and less than 25");
            }

            else if ((a % 2 == 0) && (a >= 100))
            {
                Console.WriteLine("Even");
            }
        }
    }
}
