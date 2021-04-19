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
                for (int j = 0; j < k - i-1; j++)
                {
                    if (String.Compare(books[j].Ganr, books[j + 1].Ganr)<0)
                    {
                        Book b1 = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = b1;
                    }
                    else 
                    {
                        if (String.Compare(books[j].Avtor, books[j + 1].Avtor) < 0 && String.Compare(books[j].Ganr, books[j + 1].Ganr) == 0)
                        {
                            Book b1 = books[j];
                            books[j] = books[j + 1];
                            books[j + 1] = b1;
                        }
                        else
                        {
                            if (String.Compare(books[j].Name, books[j + 1].Name) < 0 
                                && String.Compare(books[j].Ganr, books[j + 1].Ganr)== 0 && String.Compare(books[j].Avtor, books[j + 1].Avtor) ==0)
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

        public void seft_to_file()
        {
            using (StreamWriter sw = new StreamWriter("test.txt", false, System.Text.Encoding.Default))
            {
                for (int i =0; i<k; i++)
                {
                    sw.WriteLine(books[i].Name);
                    sw.WriteLine(books[i].Avtor);
                    sw.WriteLine(books[i].Ganr);
                }
            }
        }

    }
}
