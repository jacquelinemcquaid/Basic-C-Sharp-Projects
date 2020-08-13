using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            New New = new New();

            Console.WriteLine("Pick two numbers, one at a time.");
            New.Method1(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
