using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Class1 Class1 = new Class1();
            Console.WriteLine("Pick a number.");
            Class1.Method1(Convert.ToInt32(Console.ReadLine()));

            //Task 2
            Console.WriteLine("Enter your first and last name one at a time.");
            Class1.Method2(Console.ReadLine(), Console.ReadLine());

            //Task 3 and 4
            Console.WriteLine("Enter two numbers, one at a time.");
            Class1.Overloading(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter your favourite food. Then enter your favourite colour.");
            Class1.Overloading(Console.ReadLine(), Console.ReadLine());

            Console.ReadLine();

        }
    }
}
