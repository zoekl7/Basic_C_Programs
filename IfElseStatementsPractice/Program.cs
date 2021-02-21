using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatementsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalName = "Falcon";

            if (animalName == "Cheetah")
            {
                Console.WriteLine("Cheetahs can run between 50 - 80 mph");
            }
            else if (animalName == "Falcon")
            {
                Console.WriteLine("Peregrine Falcon can get up to speeds of 200+ mph");
            }
            else if (animalName != "Falcon")
            {
                Console.WriteLine("Don't know");
            }

            int num1 = 5;
            int num2 = 7;
            if (num1 > num2)
            {
                Console.WriteLine("The first number is larger");
            }
            else
            {
                Console.WriteLine("The second number is larger");
            }

            //Ternary operator
            int num3 = 7;
            int num4 = 12;
            string result = num3 > num4 ? "Num3 is greater than num4" : "num3 is not greater than num4";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
