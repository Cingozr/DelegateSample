using System;

namespace DelegationSample2
{
    public class GenericDelegate
    {
        delegate void MyGenericDelegate<T>(T param);

        public GenericDelegate()
        {
            MyGenericDelegate<string> stringDel = StringTarget;
            MyGenericDelegate<int> intDel = IntTarget;
            stringDel("Recai");
            intDel(58);
        }





        static void StringTarget(string param)
        {
            Console.WriteLine($"Gelen string Parametre: {param}");
        }

        static void IntTarget(int param)
        {
            Console.WriteLine($"Gelen int parametre: {param}");
        }
    }
}
