using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringbuilderAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // concatenate strings and use "ToUpper" method
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine("Favorite fictional place?");
            string place = Console.ReadLine();
            Console.WriteLine("Enter an adjective to describe this place:");
            string adjective = Console.ReadLine();
            string greeting = "Hello, " + name + " of " + adjective + " " + place + "!";
            Console.WriteLine(greeting);
            Console.WriteLine("(press enter to continue)");
            Console.ReadLine();

            // StringBuilder
            StringBuilder vforV = new StringBuilder();
            vforV.Append("Remember, remember, the Fifth of November, ");
            vforV.Append("the Gunpowder Treason and Plot. I know of no reason why the Gunpowder Treason ");
            vforV.Append("Should ever be forgot...");
            Console.WriteLine(vforV);
            Console.Read();
        }
    }
}
