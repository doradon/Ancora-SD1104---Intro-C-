using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._5
{
    class HouseHunter : TVApplication
    {
        private string jobTitle;
        private int currentAnnualIncome;
        private int whenBuyingHouseMonths;
        private int numberOfBedrooms;
        private int numberOfBathrooms;

        public HouseHunter(string jobTitle, int currentAnnualIncome, 
                           int whenBuyingHouseMonths, int numberOfBedrooms, 
                           int numberOfBathrooms, string firstName, 
                           string lastName, string dateOfBirth, 
                           string address, string city, string state, int zip,
                           string phoneNumber, string email) : base(firstName, 
                           lastName, dateOfBirth, address, city, state, zip, 
                           phoneNumber, email)
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.whenBuyingHouseMonths = whenBuyingHouseMonths;
            this.numberOfBedrooms = numberOfBedrooms;
            this.numberOfBathrooms = numberOfBathrooms;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Dream House Hunters\"");
        }
    }
}
