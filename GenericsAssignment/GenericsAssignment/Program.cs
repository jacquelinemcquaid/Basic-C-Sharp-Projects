using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> count = new Employee<string>();
            count.Number = "500";

            Console.WriteLine("There are " + count.Number + " employees.");
            Console.ReadLine();

            Person Person = new Person();

            Person.firstName = "Sample";
            Person.lastName = "Student";

            Person.SayName();
            Console.ReadLine();

        }
    }
}
