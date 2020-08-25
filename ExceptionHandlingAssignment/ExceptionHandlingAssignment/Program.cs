using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    public class Program
    {
        static void Main(string[] args)


        {


       

           Start:

            try
            {

                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());


                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (age == 0)
                {
                    throw new ArgumentNullException();
                }

                DateTime now = DateTime.Now;


                DateTime yearBorn = now.AddYears(-age);
                Console.WriteLine("This is the year you were born: " + yearBorn.ToString("yyyy"));

                Console.ReadLine();

            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You must enter a positive number.");
                goto Start;
                
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You can't enter '0'.");
                goto Start;
                
                
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
                goto Start;
                

                

            }
            finally
            {
                Console.ReadLine();
               
            }


            Console.ReadLine();

        }
    }

}
