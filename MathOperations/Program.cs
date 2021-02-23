using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + " multiplied by 5 equals " + MathOperators.Multiplication(number));
            Console.WriteLine(number + " minus 7 equals " + MathOperators.Subtraction(number));
            Console.WriteLine(number + " plus 700 equals " + MathOperators.Addition(number));

            Console.ReadLine();
        }
    }
}
