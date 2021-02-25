using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndClassesSuperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee() { FirstName = "Sample", LastName = "Student" };
            test.SayName();
            Console.WriteLine(test.Id);
            Console.ReadLine();
        }
    }
}
