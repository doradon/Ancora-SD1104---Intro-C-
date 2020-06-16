using System;
using System.Collections.Generic;

namespace Lab_5._6
{
    class Program
    {
        public struct Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public bool hasPremiumMembership;
        }

        static void Main(string[] args)
        {
            // 1. Customer 1 is underage
            Customer mario = new Customer();
            mario.firstName = "Mario";
            mario.lastName = "Mario";
            mario.age = 20;
            mario.hasPremiumMembership = false;

            // 2. Customer 2 is legal age but not a premium member
            Customer luigi = new Customer();
            luigi.firstName = "Luigi";
            luigi.lastName = "Mario";
            luigi.age = 22;
            luigi.hasPremiumMembership = false;

            // 3. Customer 3 is legal age and a premium member
            Customer peach = new Customer();
            peach.firstName = "Peach";
            peach.lastName = "Toadstool";
            peach.age = 21;
            peach.hasPremiumMembership = true;

            Customer[] customerArray = { mario, luigi, peach };

            foreach (Customer customer in customerArray)
            {
                if(customer.age < 21)
                {
                    Console.WriteLine(customer.firstName + " " + customer.lastName + " is under the age of 21!");
                }
                else
                {
                    Console.WriteLine(customer.firstName + " " + customer.lastName + " is of legal age.");
                }

                if (customer.hasPremiumMembership)
                {
                    Console.WriteLine(customer.firstName + " " + customer.lastName + " has Premium Membership!");
                }
                else
                {
                    Console.WriteLine(customer.firstName + " " + customer.lastName + " does not have Premium Membership!");
                }
            }
        }
    }
}
