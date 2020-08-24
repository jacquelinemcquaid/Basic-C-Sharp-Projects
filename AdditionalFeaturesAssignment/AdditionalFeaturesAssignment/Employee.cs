using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string empID;
        public string position;
        public string team;
        public Employee() : this("firstName", "lastName")
        {
            Console.WriteLine("We have wonderful employees working for our company.");
        }
        public Employee(string firstName) : this(firstName, "lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("The first name of our 'Employee of the month!'");
        }
        public Employee(string firstName, string lastName) : this(firstName, lastName, "2760", "Manager", "Software Developer")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("The first and last names of our 'Employee of the month!'");
        }
        public Employee(string firstName, string lastName, string empID, string position, string team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            this.position = position;
            this.team = team;
            Console.WriteLine("The first name, last name, empID, position and team for our 'Employee of the month!'");
        }

        public void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " " + empID + " " + position + " " + team + ".");
        }
    }
}

