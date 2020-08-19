using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employees
    {
        

        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName + "   Last Name: " + lastName + "   ID: " + Id;
        }

        public void Method()
        {
            foreach (var name in firstName)
            {
                if (name.Equals("Joe") == true)
                {
                    Console.WriteLine(name);


              }

            } }
    }
}


