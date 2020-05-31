using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationSample2
{
    public class SimpleFunc
    {
        public SimpleFunc()
        {
            Func<DateTime, int> func = GetUserAge;
            func(DateTime.Now.AddYears(-30));
        }

        static int GetUserAge(DateTime birthDate)
        {
            var age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year;
            Console.WriteLine($"Age: {age}");
            return age;
        }
    }
}
