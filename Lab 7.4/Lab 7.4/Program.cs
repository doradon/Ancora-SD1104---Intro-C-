using System;

namespace lab_7._4
{
    class Program
    {
        static void Main(string[] args)
        {

            // To test everything, in the Program Main Method, create two Dating Profiles.
            DatingProfile user1 = new DatingProfile("John", "Doe", 21, "Male");
            DatingProfile user2 = new DatingProfile("Mary", "Jane", 20, "Female");

            // Have one dating profile send a message to the other dating profile
            user1.SendMessage("Hello!", "Want to grab a bite to eat sometime this week?", user2);

            // Have the second dating profile read their messages.
            user2.ReadMessage();
        }
    }
}
