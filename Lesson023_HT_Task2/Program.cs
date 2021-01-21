using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson023_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];
            int i = 0;
            while (i < 5)
            {
                workers[i] = new Worker();
                Console.WriteLine("Enter Surnname, Initials, Job and Year:");
                workers[i].surname = Console.ReadLine();
                workers[i].initials = Console.ReadLine();
                workers[i].job = Console.ReadLine();
                try
                {
                    workers[i].year = int.Parse(Console.ReadLine());
                    i++;
                }
                catch
                {
                    Console.WriteLine($"Error: BAD YEAR");
                }
            }

            Array.Sort<Worker>(workers);

            for (int j = 0; j < 5; j++)
            {

                Console.WriteLine(workers[j].surname);
            }

            int stz = int.Parse(Console.ReadLine());
            for (int j = 0; j < 5; j++)
                if (workers[j].year > stz)
                {
                    Console.WriteLine(workers[j].surname);
                }
        }
    }
}

