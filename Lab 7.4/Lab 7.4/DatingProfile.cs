using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7._4
{
    class DatingProfile
    {
        public string firstName;
        private string _lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        //  Constructor that lets us fill out firstname, lastname, age, and gender of the profile
        public DatingProfile(string firstName, string _lastName, int age, string gender)
        {
            this.firstName = firstName;
            this._lastName = _lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }

        // This will let the user write their bio text to their profile.
        public void WriteBio(string text)
        {
            this.bio = text;
        }

        // This will let the user read their (unread) messages.
        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (!message.isRead)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }

        // Takes another Dating Profile as input and some text of the message.
        public void SendMessage(string messageTitle, string messageData, DatingProfile toProfile)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            toProfile.myMessages.Add(message);
        }
    }
}
