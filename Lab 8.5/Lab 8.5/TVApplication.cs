using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._5
{
    class TVApplication
    {
        protected string firstName;
        protected string lastName;
        protected string dateOfBirth;
        protected string address;
        protected string city;
        protected string state;
        protected int zip;
        protected string phoneNumber;
        protected string email;
        protected bool applicationSubmitted;
        protected bool applicationAccepted;

        // TVApplication constructor
        public TVApplication(string firstName, string lastName, string dateOfBirth,
                           string address, string city, string state, int zip,
                           string phoneNumber, string email)
        {
            // Base properties
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.applicationSubmitted = false;
            this.applicationAccepted = false;
        }

        // Submit () will set Application Submitted to true and print to console
        // “Application has been submitted.”
        public void Submit()
        {
            this.applicationSubmitted = true;
            Console.WriteLine("Application has been submitted");
        }
        // Accept() will set the application to accepted and print “Application 
        // Accepted”.
        public virtual void Accept()
        {
            this.applicationAccepted = true;
            Console.WriteLine("Application Accepted");
        }
    }
}
