using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndClassesOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = mathOperations.mathOp(50);
            Console.WriteLine(numberOne);

            int numberTwo = mathOperations.mathOp(17.5m);
            Console.WriteLine(numberTwo);

            int numberThree = mathOperations.mathOp("9");
            Console.WriteLine(numberThree);

            Console.ReadLine();

            Console.WriteLine("Please enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number / mathOperations.mathOp(number));
            Console.ReadLine();
        }
    }
}
