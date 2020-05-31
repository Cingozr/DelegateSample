using System;

namespace DelegationSample2
{
    class Program
    {
        delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            MathOperation mathOp = SimpleMath.Add;
            mathOp += SimpleMath.Subtract;

            foreach (Delegate del in mathOp.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {del.Method}");
                Console.WriteLine($"Method Name: {del.Target}");
            }

            Console.ReadLine();
        }
    }
}
