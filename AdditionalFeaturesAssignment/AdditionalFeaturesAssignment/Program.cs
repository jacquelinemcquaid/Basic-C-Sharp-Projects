using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            const string firstName = "Jacqueline";

            Console.WriteLine("What is your first name?");
            Console.WriteLine(firstName);
            Console.ReadLine();

            var favouriteAnimal = "Dog";

            Console.WriteLine("What is your favourite animal?");
            Console.WriteLine(favouriteAnimal);
            Console.ReadLine();

            Employee employee = new Employee("Fiona", "Rogers");
            employee.printName();

            Console.ReadLine();

        }
    }
}
