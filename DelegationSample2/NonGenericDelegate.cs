using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSample2
{
    delegate void MyStringDelegate(string param1);
    delegate void MyIntDelegate(int param1);
    public class NonGenericDelegate
    {
        public NonGenericDelegate()
        {
            MyStringDelegate stringDelegate = StringTarget;
            MyIntDelegate intDelegate = IntTarget;
            stringDelegate("Recai");
            intDelegate(58);
        }


        public void StringTarget(string param1)
        {
            Console.WriteLine($"String deger: {param1.ToUpper()}");
        }
        public void IntTarget(int param1)
        {
            Console.WriteLine($"Int deger:{++param1}");
        }
    }
}
