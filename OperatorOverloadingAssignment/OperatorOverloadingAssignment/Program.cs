using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overload the "==" operator so it checks if two Employee objects 
            //are equal by comparing their Id property.

            Employee Employee = new Employee();

            Console.WriteLine("Person 1, please enter your 3 digit ID. Then, Person 2, please enter your 3 digit ID.");
            Employee.Compare(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Person 2, please enter you 3 letter ID. Then, Person 2, please enter your 3 letter ID.");
            Employee.Compare(Console.ReadLine(), Console.ReadLine());


          
            Console.ReadLine();


        }
    }
}
