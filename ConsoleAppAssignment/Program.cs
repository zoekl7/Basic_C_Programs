using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What do you want to multiply by 50? Integers only ");
            //int num1 = ;
            // Console.WriteLine(num1 * 50);
            //Console.ReadLine();

            int num1 = 50;
            int currentTemp = int input();

            //bool isWarm = currentTemp >= roomTemp;
            bool isWarm = currentTemp == roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
