using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignement
{
    class Class1
    {
        public void Method1(int num1)
        {
            Console.WriteLine($"{num1} / 2 = " + (num1 / 2));
        }

        public void Method2(string firstName, string lastName)
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }

        public static void Overloading(int a, int b)
        {
            Console.WriteLine($" {a} + {b} = " + (a + b));
            
        }

        public static void Overloading(string c, string d)
        {
            Console.WriteLine(" My favourit food is " + c + ", and my favourite colour is " + d);
        }

    }
}
