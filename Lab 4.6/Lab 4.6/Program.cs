using System;

namespace Lab_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday"};
            string[] tasks = new string[7];
            int index = 0;

            foreach (string day in days)
            {
                Console.WriteLine($"Type in a new Task for {day}");
                tasks[index] = Console.ReadLine();

                index++;
            }

            index = 0;
            foreach (string day in days)
            {
                Console.WriteLine($"{day}: {tasks[index]}");

                index++;
            }
        }
    }
}
