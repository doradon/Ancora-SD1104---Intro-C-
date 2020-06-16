using System;

namespace Lab_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# program to print on screen the output of adding, subtracting,
            // multiplying and dividing of two numbers which will be entered by the user.
            Console.WriteLine("Enter a Number:");
            string userInput = Console.ReadLine();
            int num1 = int.Parse(userInput);
            Console.WriteLine("Enter another Number:");
            userInput = Console.ReadLine();
            int num2 = int.Parse(userInput);
            Console.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + (num1 + num2).ToString());
            Console.WriteLine(num1.ToString() + " - " + num2.ToString() + " = " + (num1 - num2).ToString());
            Console.WriteLine(num1.ToString() + " x " + num2.ToString() + " = " + (num1 * num2).ToString());
            Console.WriteLine(num1.ToString() + " / " + num2.ToString() + " = " + ((double)num1 / (double)num2).ToString());

            // 2. Write a C# program to print Hello and your name (which you will type in on the
            // Console) in a separate line.
            Console.WriteLine("Please Enter Your Name:");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);

            // 3. Write a C# program to print the output of multiplication of three numbers which
            // will be entered by the user
            Console.WriteLine("Enter the First Number:");
            userInput = Console.ReadLine();
            int num3 = int.Parse(userInput);
            Console.WriteLine("Enter the Second Number:");
            userInput = Console.ReadLine();
            int num4 = int.Parse(userInput);
            Console.WriteLine("Enter the Last Number:");
            userInput = Console.ReadLine();
            int num5 = int.Parse(userInput);
            Console.WriteLine(num3.ToString() + " x " + num4.ToString() + " x " + num5.ToString() + " = "
                              + (num3 * num4 * num5).ToString());

            // 4. Write a C# program that takes an age (for example 20) as input and prints
            // something like "You look younger than 20 (the age the user entered)".
            Console.WriteLine("Please Enter Your Age");
            userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            Console.WriteLine("You look younger than " + age.ToString());
        }
    }
}
