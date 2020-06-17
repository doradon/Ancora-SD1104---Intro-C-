using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._5
{
    class ParadiseIsland : TVApplication
    {
        private string gender;
        private string nameOfSO;
        private int yearsDating;

        public ParadiseIsland (string gender, string nameOfSO, int yearsDating,
                               string firstName, string lastName, string dateOfBirth,
                               string address, string city, string state, int zip,
                               string phoneNumber, string email) : base(firstName,
                               lastName, dateOfBirth, address, city, state, zip,
                               phoneNumber, email)
        {
            this.gender = gender;
            this.nameOfSO = nameOfSO;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Paradise Island\"");
        }
    }
}
