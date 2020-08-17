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
            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Jerry");
            names.Add("Jamie");
            names.Add("Jennifer");

            Console.WriteLine("Here is a list of employees who work the night shift: ");
            Console.WriteLine();

            foreach (string list in names)
            {
                Console.WriteLine(list);
            }
            Console.ReadLine();

            //Task 4
            List<int> num = new List<int>();
            num.Add(4510);
            num.Add(4511);
            num.Add(4512);
            num.Add(4513);

            Console.WriteLine("Here is a list of ID numbers for each of the employees above: ");
            Console.WriteLine();

            foreach (int anum in num)
            {
                Console.WriteLine(anum);
            }
            Console.ReadLine();

            //Task 5

            Console.WriteLine("If the employees name starts with 'J', their name will be printed below: ");

            foreach (string j in names)
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

            } Console.ReadLine();


            


        }
    }
}
