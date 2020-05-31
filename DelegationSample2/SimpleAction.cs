using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSample2
{

    public class SimpleAction
    {
        public SimpleAction()
        {
            Action<string, int> action = DisplayAge;
            action("Recai", 30);
        }


        static void DisplayAge(string fullName, int age)
        {
            Console.WriteLine($"Isim : {fullName} - Yas : {age}");
        }
    }
}
