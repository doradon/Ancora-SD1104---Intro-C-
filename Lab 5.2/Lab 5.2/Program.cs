using System;
using System.Collections.Generic;

namespace Lab_5._2
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            // Create a list to hold tasks
            List<string> tasks = new List<string>();

            // For each valiue in the enum.. let the user create a task
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                tasks.Add(task);
            }

            // Print all of the tasks
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
