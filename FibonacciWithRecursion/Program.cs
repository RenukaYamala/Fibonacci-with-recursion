using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciWithRecursion
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Limit");
            int limit =int.Parse(Console.ReadLine());
           // fibonacci(limit);
            Console.WriteLine(" " + fibonacci(limit));
        }
        public static int fibonacci(int number)
        {

            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return fibonacci(number - 2) + fibonacci(number - 1);
            }

        }

    }
}
