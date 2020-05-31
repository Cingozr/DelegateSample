using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSample2
{
    public class SimpleMath
    {
        public static int Add(int x, int y)
        {
            int retVal = x + y;
            Console.WriteLine($"Add:{retVal}");
            return retVal;
        }

        public static int Subtract(int x, int y)
        {
            int retval = x - y;
            Console.WriteLine($"Substract: {retval}");
            return retval;
        }
    }
}
