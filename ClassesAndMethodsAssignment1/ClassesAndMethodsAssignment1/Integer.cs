using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    class Integer
    {
        public void Method1()
        {
            Console.WriteLine("Pick a number to multiply by 10.");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number multiplied by 10 equals " + (number1 * 10));
        }

        public void Method2()
        {
            Console.WriteLine("Pick a number that contains a decimal.");
            float number2 = float.Parse(Console.ReadLine());

            int total = (int)number2 / 10;


            Console.WriteLine("Your number divided by 10 equals " + total);
        }

        public void Method3()
        {
            Console.WriteLine("Pick a number between 1 and 100 and we will add it to the number 50.");
            string number = Console.ReadLine();

            int parsedNumber = int.Parse(number);

            int intNumber = parsedNumber;
            Console.WriteLine("You number plus 50 equals " + (50 + intNumber));

            Console.ReadLine();
        }

    }
}
