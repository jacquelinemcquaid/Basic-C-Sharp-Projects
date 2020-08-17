using System;
using System.Collections.Generic;
using System.Globalization;
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
        
            //Task 1, 2, 3
            Employee<string> names = new Employee<string>();
            names.Things = new List<string>();
            names.Things.Add("James");
            names.Things.Add("Jerry");
            names.Things.Add("Jamie");
            names.Things.Add("Jennifer");

            Console.WriteLine("Here is a list of employees who work the night shift: ");
            Console.WriteLine();

            foreach (string list in names.Things)
            {
                Console.WriteLine(list);
            }
            Console.ReadLine();

            //Task 4
            Employee<int> numbers = new Employee<int>();
            numbers.Integers = new List<int>();
            numbers.Integers.Add(4510);
            numbers.Integers.Add(4510);
            numbers.Integers.Add(4511);
            numbers.Integers.Add(4512);
            numbers.Integers.Add(4513);

            Console.WriteLine("Here is a list of ID numbers for each of the employees above: ");
            

            foreach (int num1 in numbers.Integers)
            {
                Console.WriteLine(num1);
            }
            Console.ReadLine();

            //Task 5

            Console.WriteLine("If the employees name starts with 'J', their name will be printed below: ");
            
            foreach (string j in names.Things)
            {

                if (j.Contains("J") == true)
                {
                    Console.WriteLine(j + "  Type 'okay' to continue");

                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine("There are no names in this list that contain the letter 'J'. ");
                    Console.ReadLine();
                }

            }
            Console.ReadLine();





        }
    }
}
