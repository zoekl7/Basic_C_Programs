using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileStatementAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 while statement
            Console.WriteLine("Simple multiplication loop");
            int number = 5;
            while (number <= 10000)
            {
                Console.WriteLine(number);
                number *= 5;
            }
            Console.WriteLine("Press Enter for 'do while' statement");
            Console.ReadLine();

            // Part 2 do while statement

            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int month;

            do
            {
                Console.WriteLine("Enter a month by number (1 to 12):");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > currentMonth && month <= 12)
                {
                    Console.WriteLine("Month " + month.ToString() + " will happen later this year: " + (month - currentMonth).ToString() + " month(s) from now...");
                }
                else if (month < currentMonth && month >= 1)
                {
                    Console.WriteLine("Month " + month.ToString() + " happened earlier this year: " + (currentMonth - month).ToString() + " month(s) ago...");
                }
                else if (month == currentMonth)
                {
                    Console.WriteLine("Month " + month.ToString() + " is the current month! Enjoy the rest of your month!");
                }
                else
                {
                    Console.WriteLine("That is not a valid month. Enter a month from 1 to 12.");
                }
            }
            while (month != currentMonth);
            Console.Read();
        }
    }
}
