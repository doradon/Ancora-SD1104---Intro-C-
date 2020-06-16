using System;
using System.Runtime.CompilerServices;

namespace Lab_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWorld = "viagra";
            bool isSpam = false;
            Console.WriteLine("Please enter a message to check for spam:");
            string message = Console.ReadLine();
            if(message.Contains(blackListWorld))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = true;
                Console.WriteLine("The message is not spam");
            }
        }
    }
}
