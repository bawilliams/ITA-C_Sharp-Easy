using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (number >= 10)
            {
                Console.WriteLine("This number is big enough");
            }
        }
    }
}

