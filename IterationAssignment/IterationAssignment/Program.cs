using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string[] animals = { "Dog", "Cat", "Horse", "Bunny" };
            Console.WriteLine("Enter the name of a Country. This Country will display beside an array of animals below.");
            string country = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i] + ": " + country);

            }

            Console.ReadLine();



            Console.WriteLine("Type 'okay' to see a count up from 1 to 10.");
            Console.ReadLine();

            //Task 2

            //INFINITE LOOP
            //for (int a = 1; a > 0; a++)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();

            //Task 3

            //FIXED LOOP
            for (int u = 1; u > 0 && u <= 10; u++)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("Type 'okay' to compare a list of math scores.");
            Console.ReadLine();

            //Task 4

            List<int> mathScores = new List<int>();
            mathScores.Add(75);
            mathScores.Add(90);
            mathScores.Add(88);
            mathScores.Add(92);
            mathScores.Add(66);
            mathScores.Add(80);
            mathScores.Add(99);

            foreach (int score in mathScores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("This is the list of math scores in a 7 person class. If the score is below 95, the student did not get Honours. If the score is below or equal to 85, the student failed.");
            Console.WriteLine("Type 'okay' to continue.");
            Console.ReadLine();

            foreach (int honours in mathScores)
            {
                if (honours < 95)
                {
                    Console.WriteLine("Did not get Honours: " + honours);
                }
            }

            //Task 5

            foreach (int score in mathScores)
            {
                if (score <= 85)
                {
                    Console.WriteLine("Failed:" + score);
                }

            }

            //Task 6 / 7 / 8

            List<string> arr = new List<string>();
            arr.Add("mia");
            arr.Add("jay");
            arr.Add("joy");
            int a = arr.IndexOf("mia");
            int b = arr.IndexOf("jay");
            int c = arr.IndexOf("joy");

            Console.WriteLine("Here is a list of names: ");

            foreach (string names9 in arr)
            {

                Console.WriteLine(names9);
            }

        start:

            Console.WriteLine("Type a name that you see in the list.");
            string word = Console.ReadLine();



            foreach (string name9 in arr)


            {
                if (word == "mia")
                {
                    Console.WriteLine("The index of this name is " + a + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;

                }
                else if (word == "jay")
                {
                    Console.WriteLine("The index of this name is " + b + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;
                }

                else if (word == "joy")
                {
                    Console.WriteLine("The index of this name is " + c + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;
                }

                else
                {
                    Console.WriteLine("The name you picked is not in the list. Please type 'okay' to try again.");
                    Console.ReadLine();
                    goto start;
                }
            }


            Console.WriteLine("Here is a new list of names:");
            Console.ReadLine();

            // Task 9 / 10

            List<string> names11 = new List<string>() { "jane", "jane", "kelly", "ben" };
            int d = names11.IndexOf("jane");
            int e = Convert.ToInt32("1");
            int f = names11.IndexOf("kelly");
            int g = names11.IndexOf("ben");

            foreach (string task9 in names11)
            {
                Console.WriteLine(task9);
            }

        here:


            Console.WriteLine("Type a name that you see in the list.");
            string word2 = Console.ReadLine();



            foreach (string task9 in names11)

            {
                if (word2 == "jane")
                {
                    Console.WriteLine("The index of this name is " + d + " and " + e + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;

                }
                else if (word2 == "kelly")
                {
                    Console.WriteLine("The index of this name is " + f + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;
                }

                else if (word2 == "ben")
                {
                    Console.WriteLine("The index of this name is " + g + ". Type 'okay' to continue.");
                    Console.ReadLine();
                    break;
                }


                else
                {
                    Console.WriteLine("The name you picked is not in the list. Please type 'okay' to try again.");
                    Console.ReadLine();
                    goto here;

                }
            }

            Console.WriteLine("Here is the list of names again: ");
            Console.ReadLine();


           // Task 11

            List<string> names2 = new List<string>() { "jane", "jane", "kelly", "ben" };

            foreach (string task11 in names2)
            {
                Console.WriteLine(task11);

            }
            Console.WriteLine("Type a name to see if there is a duplicate in the list.");
            string letter5 = Console.ReadLine();

            foreach (string task11 in names2)
            {
                if (letter5 == task11)
                {
                    Console.WriteLine(task11 + ":" + letter5 + ", This is a duplicate name.");
                }
                else
                {
                    Console.WriteLine(task11 + ":" + letter5 + ", This is not a duplicate name.");
                }
            }

            Console.ReadLine();







        }










    }
}
