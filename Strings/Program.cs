using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Skywalker";
            string quote = "The man said, \"Hello, Skywalker.\"\nHello on a new line.\n\tHello on a tab.";
            // string fileName = "C:\\Users\\Zoe";
            string fileName = @"C:\Users\Zoe";

            // bool trueOrFalse = name.Contains("s");
            bool trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);

            // create instance of class StringBuilder:
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Zoe");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
