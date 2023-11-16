﻿namespace Lab4
{
    internal class Reviewer : Reader
    {
        static Random rnd = new Random();

        public Reviewer(Reader reader) :
            base(reader.FirstName, reader.LastName, reader.wiek, reader.books)
        {
        }

        public string Wypisz(int i)
        {
            return books[i].Title + ":" + " " + rnd.Next(1, 10);
        }
    }
}
