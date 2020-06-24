using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_11._5
{
    class HTMLGenerator
    {
        private string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Lab 11-5.html";
        private string title;
        private string header;
        private List<string> htmlList = new List<string>();
        private StringBuilder htmlText = new StringBuilder();
        private string titleOpen = "<title>";
        private string titleClose = "</title>";
        private string headOpen = "<head>";
        private string headClose = "</head>";
        private string bodyOpen = "<body>";
        private string bodyClose = "</body>";
        private string h1Open = "<h1>";
        private string h1Close = "</h1>";
        private string ulOpen = "<ul>";
        private string ulClose = "</ul>";
        private string liOpen = "<li>";
        private string liClose = "</li>";

        public HTMLGenerator(string title, string header, List<Film> films)
        {
            htmlText.Append(headOpen);
            htmlText.Append(titleOpen);
            htmlText.Append(title);
            htmlText.Append(titleClose);
            htmlText.Append(headClose);

            htmlText.Append(bodyOpen);

            htmlText.Append(h1Open);
            htmlText.Append(header);
            htmlText.Append(h1Close);

            htmlText.Append(ulOpen);
            foreach (Film f in films)
            {
                htmlText.Append(liOpen);
                htmlText.Append(f.title + " " + f.description);
                htmlText.Append(liClose);
            }
            htmlText.Append(ulClose);

            htmlText.Append(bodyClose);

            File.AppendAllText(filename, htmlText.ToString());
            Console.WriteLine("HTML Generated! Check your Desktop!");
        }
    }
}
