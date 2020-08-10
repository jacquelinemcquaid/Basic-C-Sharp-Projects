using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a number between 0 and 3 to obtain a name from the array.");
            int a = Convert.ToInt32(Console.ReadLine());

            string[] names = { "Jerry", "Joe", "Lacey", "Tessa" };

            if (a >= 0 && a <= 3)
            {

                Console.WriteLine(names[a]);
                Console.ReadLine();
            }

            else if (a > 3)
            {
                Console.WriteLine("Error. Pick a number between 1 and 3.");
                Console.ReadLine();


            }

           


            Console.WriteLine("Select a number between 0 and 3 to obtain a number from the array.");
            int b = Convert.ToInt32(Console.ReadLine());

            int[] numbers = { 3, 20, 65, 100 };

            if (b >= 0 && b <= 3)
            {
                Console.WriteLine(numbers[b]);
                Console.ReadLine();

            }

            else if (b > 3)
            {
                Console.WriteLine("Error. Pick a number between 1 and 3.");
                Console.ReadLine();


            }

            

          

            Console.WriteLine("Select a number between 0 and 3 to obtain a theme from the list.");
            int theme = Convert.ToInt32(Console.ReadLine());

            List<string> intList = new List<string>();
            intList.Add("Family");
            intList.Add("Food");
            intList.Add("Education");
            intList.Add("Travel");

            Console.WriteLine(intList[theme]);
            Console.ReadLine();
           

         

        }
    }
}
