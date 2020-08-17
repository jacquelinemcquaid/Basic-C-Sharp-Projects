using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week beginning with a capital letter.");
            string day = Console.ReadLine();
            

            try
            {
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);

                if (days == DaysOfTheWeek.Monday)
                {
                    Console.WriteLine("You entered Monday.");
                 
                }

                else if (days == DaysOfTheWeek.Tuesday)
                    {
                    Console.WriteLine("You entered Tuesday.");

                }

                else if (days == DaysOfTheWeek.Wednesday)
                    {
                    Console.WriteLine("You entered Wednesday.");
                }

                else if (days == DaysOfTheWeek.Thursday)
                {
                    Console.WriteLine("You entered Thursday.");

                }

                else if (days == DaysOfTheWeek.Friday)
                {
                    Console.WriteLine("You entered Friday.");
                }
                else if (days == DaysOfTheWeek.Saturday)
                {
                    Console.WriteLine("You entered Saturday.");


                }
                else if (days == DaysOfTheWeek.Sunday)
                {
                    Console.WriteLine("You entered Sunday.");
                }
   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please write an actual day of the week.");
            }

            Console.ReadLine();
        }
            public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        

    }
}

