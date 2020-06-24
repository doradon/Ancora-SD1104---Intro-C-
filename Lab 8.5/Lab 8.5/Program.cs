using System;

namespace Lab_8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create applications for Dream House Hunters, Paradise island,
            // and Above deck.Submit and accept them all.

            HouseHunter app1 = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith",
                                               "2/4/1975", "111 Bravo Way", "Los Angeles", "California", 
                                               90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland app2 = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", 
                                                     "211 Love Rd", "Los Angeles", "California", 90001, 
                                                     "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck app3 = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Way", 
                                           "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com");

            app1.Submit();
            app1.Accept();

            app2.Submit();
            app2.Accept();

            app3.Submit();
            app3.Accept(); 
        }
    }
}
