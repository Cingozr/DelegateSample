using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSample2
{
    public class SimpleMath
    {

        delegate int MathOperation(int x, int y);
        public SimpleMath()
        {
            MathOperation mathOp = SimpleMath.Add;
            mathOp += SimpleMath.Subtract;
            mathOp(5, 3);

            foreach (Delegate del in mathOp.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {del.Method}");
                Console.WriteLine($"Method Name: {del.Target}");
            }
        }

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
