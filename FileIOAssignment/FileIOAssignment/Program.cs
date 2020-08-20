using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            using(StreamWriter file = new StreamWriter (@"C:\Users\jacqu\Logs\Test.txt", true))
            {
                file.WriteLine(number);
            }

            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"C:\Users\jacqu\Logs\Test.txt");
            

            Process.Start(psi);


        }
    }
}
