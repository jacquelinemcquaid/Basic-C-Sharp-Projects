using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee();

           
            Employee.firstName = "Sample";
            Employee.lastName = "Student";

            Employee.SayName();
            Console.ReadLine();
        }
    }
}
