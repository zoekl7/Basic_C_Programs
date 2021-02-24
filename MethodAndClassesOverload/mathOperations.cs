using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndClassesOverload
{
    public class mathOperations
    {
        private static int num;

        public static int mathOp(int number)
        {
            return number * 2;
        }

        public static int mathOp(decimal number)
        {
            int result = Convert.ToInt32(number);
            result = result / 2;
            return result;
        }

        public static int mathOp(string number)
        {
            num = Convert.ToInt32(number);
            return num + 25000;
        }
    }
}