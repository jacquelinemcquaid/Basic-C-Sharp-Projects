using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Person
    {

        public void Compare(int a, int b)
        {
            

            if (a == b)
            {
                Console.WriteLine("Person 1 and Person 2 have the same ID.");
                
            }
            else if (a != b)
            {
                Console.WriteLine("Person 1 and Person 2 have different ID's.");
               
            }

        }

        public void Compare(string c, string d)
        {


            if (c == d)
            {
                Console.WriteLine("Person 1 and Person 2 have the same ID.");
               

            }
            else if (c != d)
            {
                Console.WriteLine("Person1 and Person 2 do not have the same ID.");
              
            }

        }





    }
}
