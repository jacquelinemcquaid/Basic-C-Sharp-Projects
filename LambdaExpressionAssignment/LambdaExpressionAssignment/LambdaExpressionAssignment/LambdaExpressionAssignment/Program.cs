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

            Console.WriteLine("If the employees first name is 'Joe', their information will be printed below:");


            foreach (Employees name in employees)
            {
                if (Employees.firstName == "Joe")
                {

                    Console.WriteLine(name);


                }


                Console.ReadLine();

            }
            //lambda tasks

            Console.WriteLine("Here is a list of employees with the first name 'Joe'.");

            foreach (Employees person in employees.FindAll(e => (e.firstName == "Joe")).ToList())
            {
                Console.WriteLine("Name : " + person.firstName + " Last Name: " + person.lastName + " ID: " + person.Id);
            }
            Console.ReadLine();




            Console.WriteLine("Here is a list of employees with an Id number greater than 5.");

            foreach (Employees people in employees.FindAll(x => (x.Id > 5)).ToList())
            {
                Console.WriteLine("Name : " + people.firstName + " Last Name: " + people.lastName + " ID: " + people.Id);
            }

            Console.ReadLine();

        }


    }
}