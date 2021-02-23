using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndClassesAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = MathOperations.mathOp(70);
            Console.WriteLine(numberOne);

            double numberTwo = MathOperations.mathOp(13.77);
            Console.WriteLine(numberTwo);

            int numberThree = MathOperations.mathOp("7");
            Console.WriteLine(numberThree);

            Console.ReadLine();
        }
    }
}
