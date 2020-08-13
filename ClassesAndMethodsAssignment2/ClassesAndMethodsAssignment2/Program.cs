using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {


            Class1 Class1 = new Class1();
            //Task 1
            Class1.Method1(5);
            Class1.Method1(6, 8);

            //Task 2
            Console.WriteLine("Enter either one number, or two numbers (one at a time).");
            Class1.Method2(Convert.ToInt32(Console.ReadLine()));
            Class1.Method2(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


            Console.ReadLine();
        }
    }
}
