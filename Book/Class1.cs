using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
            for (int i=0; i < k - 1; i++)
            {
                for (int j = 0; j < k - i; j++)
                {
                    if (String.Compare(books[j].Ganr, books[j + 1].Ganr)<0)
                    {
                        Book b1 = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = b1;
                    }
                }
            }
        }


    }
}
