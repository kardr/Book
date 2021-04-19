using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Class1
    {
        int n = 0;
        Book[] books;
        int k = 0;

        public Class1(int newn)
        {
            n = newn;
            books = new Book[n];

        }

        public void Add(string nName, string nAvtor, string nGanr)
        {
            Book b = new Book(nName, nAvtor, nGanr);
            books[k] = b;
            k++;

        }
        public void Sort()
        {

        }

    }
}
