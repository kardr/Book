using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива:");

            int n = Convert.ToInt32(Console.ReadLine());

            Class1 librarary = new Class1(n);
            for(int  i = 0; i < n; i++)
            {
                Console.WriteLine("заполнение записи №" + (i + 1).ToString());
                Console.WriteLine("Размер массива:");//avtor
                string s1 = Console.ReadLine();
                Console.WriteLine("Размер массива:");
                string s2 = Console.ReadLine();
                Console.WriteLine("Размер массива:");
                string s3 = Console.ReadLine();
                librarary.Add(s1, s2, s3);
            }

            librarary.Sort();
            librarary.seft_to_file();


            Console.ReadKey();

        }
    }
}
