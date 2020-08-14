using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    public class Employee : Person, IQuittable
    {

        
       public void Quit()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name + " wants to quit his/her job. Type 'okay' to continue.");
            Console.ReadLine();
            
        }

        public void notice()
        {
            Console.WriteLine("How many weeks notice are you giving?");
            int weeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("He/she is giving " + weeks + " weeks notice.");
            Console.ReadLine();
        }
    }
}
