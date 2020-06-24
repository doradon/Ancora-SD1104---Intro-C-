using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_9._4
{
    class HTMLGenerator
    {
        private string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Lab 9-4.html";
        private string header;
        private List<string> htmlList = new List<string>();
        private StringBuilder htmlText = new StringBuilder();
        private string bodyOpen = "<body>";
        private string bodyClose = "</body>";
        private string h1Open = "<h1>";
        private string h1Close = "</h1>";
        private string ulOpen = "<ul>";
        private string ulClose = "</ul>";
        private string liOpen = "<li>";
        private string liClose = "</li>";

        public HTMLGenerator()
        {
            htmlText.Append(bodyOpen);

            setHeader();
            
            htmlText.Append(h1Open);
            htmlText.Append(header);
            htmlText.Append(h1Close);

            addToList();

            htmlText.Append(ulOpen);
            foreach (string item in htmlList)
            {
                htmlText.Append(liOpen);
                htmlText.Append(item);
                htmlText.Append(liClose);
            }
            htmlText.Append(ulClose);

            htmlText.Append(bodyClose);

            File.AppendAllText(filename, htmlText.ToString());
            Console.WriteLine("HTML Generated! Check your Desktop!");
        }

        public void setHeader()
        {
           
            Console.WriteLine("Enter text for HTML header");
            header = Console.ReadLine();
        }

        public void addToList()
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter an item into the list:");
                    htmlList.Add(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter another item to the list:");
                    htmlList.Add(Console.ReadLine());
                }
            }
            
        }
    }
}
