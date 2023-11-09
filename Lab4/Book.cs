using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Book
    {
        string title;
        Persona author;
        public int dataWyd;

        public string Title
        {
            get { return title; }
            set { }
        }

        public Book(Persona author, string title, int dataWyd)
        {
            this.author = author;
            this.title = title;
            this.dataWyd = dataWyd;
        }
        public void View()
        {
            Console.WriteLine($"Autor: {author.FirstName} {author.LastName}\nNazwa książki: {title}\nData wydania: {dataWyd}");
        }
    }
}
