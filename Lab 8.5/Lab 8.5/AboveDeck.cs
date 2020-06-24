using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._5
{
    class AboveDeck : TVApplication
    {
        private int yearsBoatingExp;
        private string nationality;

        public AboveDeck (int yearsBoatingExp, string nationality, string firstName,
                          string lastName, string dateOfBirth, string address, 
                          string city, string state, int zip, string phoneNumber, 
                          string email) : base(firstName, lastName, dateOfBirth, 
                          address, city, state, zip, phoneNumber, email)
        {
            this.yearsBoatingExp = yearsBoatingExp;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Above Deck\"");
        }
    }
}
