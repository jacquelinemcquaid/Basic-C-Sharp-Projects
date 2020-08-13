using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ClassesAndMethodsAssignment2
{
    class Class1
    {
       static public void Method1(int number1, [Optional] int number2)
        {
            Console.WriteLine(number1 * number2);
        
        }

        static public void Method2(int num1, [Optional] int num2)
        {
           
         
            Console.WriteLine(num1 + num2);

            

        }
    }
}
