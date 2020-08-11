using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numbers = new List<int>() { 20, 15, 10, 5, 1 };

                Console.WriteLine("Here is a list of numbers.");

                foreach (int number in numbers)

                {
                    
                    Console.WriteLine(number);
                }
                Console.WriteLine("Pick a number.");
                int numberPicked = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number / numberPicked);
                }

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }

        }
       
    }
}
