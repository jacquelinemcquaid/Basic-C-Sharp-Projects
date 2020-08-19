using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            //Task1

            Employees Employees = new Employees();

            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees() { firstName = "Katie", lastName = "McDonald", Id = 6701 });
            employees.Add(new Employees() { firstName = "Joe", lastName = "Turner", Id = 6702 });
            employees.Add(new Employees() { firstName = "Jamie", lastName = "Mckay", Id = 6703 });
            employees.Add(new Employees() { firstName = "Alexis", lastName = "Adams", Id = 6704 });
            employees.Add(new Employees() { firstName = "Joe", lastName = "Brandon", Id = 6705 });
            employees.Add(new Employees() { firstName = "Bella", lastName = "McPhail", Id = 6706 });
            employees.Add(new Employees() { firstName = "Fiona", lastName = "Ross", Id = 6707 });
            employees.Add(new Employees() { firstName = "Chris", lastName = "Murphy", Id = 6708 });
            employees.Add(new Employees() { firstName = "Matt", lastName = "McQuaid", Id = 6709 });
            employees.Add(new Employees() { firstName = "Faith", lastName = "Sharp", Id = 6710 });

       
            Console.WriteLine("Here is a list of employees:");

            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //Task2

            Console.WriteLine("If the employees first name is 'Joe', their name will be printed below:");
         

            foreach (Employees name in employees)
            {
                if (Employees.firstName = "Joe")
                {
                    Console.WriteLine(name);


                }
                Console.ReadLine();

                //Exercise if this were just string values

                //List<string> firstnames = new List<string>();
                //firstnames.Add("Katie");
                //firstnames.Add("Joe");
                //firstnames.Add("Jamie");
                //firstnames.Add("Alexis");
                //firstnames.Add("Joe");
                //firstnames.Add("Bella");
                //firstnames.Add("Fiona");
                //firstnames.Add("Chris");
                //firstnames.Add("Matt");
                //firstnames.Add("Faith");

                //foreach (string name in firstnames)
                //{

                //    if (name.Equals("Joe"))
                //    {
                //        Console.WriteLine(name);

                //    }
                //}

                //Console.ReadLine();



                //lambda task

            }
        }
    }
}