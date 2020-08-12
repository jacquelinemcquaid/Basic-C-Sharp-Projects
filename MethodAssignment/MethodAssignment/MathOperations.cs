using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class MathOperations
    {
        
        public void Method1()
        {
            Console.WriteLine("Pick a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You number added to itself equals " + (number1 + number1) );
            
            
        }

        public void Method2()

        {
            Console.WriteLine("Pick a number.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number divided by 10 equals " + (number2 / 10));
        }

        public void Method3()
        {
            Console.WriteLine("Pick a number.");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You number multiplied by itself = " + (number3 * number3));
        }


    }
}
