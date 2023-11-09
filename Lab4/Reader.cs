using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Reader
    {
        public Book[] books;

        public Reader(string firstname, string lastname, int wiek, Book[] books) :
            base(firstname, lastname, wiek)
        {
            this.books = books;
        }

        public void ViewBook()
        {
            Console.WriteLine("Przeczytane książki: ");
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
