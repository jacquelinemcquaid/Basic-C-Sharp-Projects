using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("The time in " + number + " hours from now will be: ");

            DateTime now2 = now.AddHours(number);
            Console.WriteLine(now2);
            Console.ReadLine();

            //Tutorial Video
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

        }
    }
}
