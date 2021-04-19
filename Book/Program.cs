using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Размер массива:");


                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("Введите число больше 0!", "Ошибка");
                }
                else if (n < 0)
                {
                    Console.WriteLine("Введите число больше 0!", "Ошибка");
                }
                else
                {
                    Class1 librarary = new Class1(n);
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Заполнение записи №" + (i + 1).ToString());
                        Console.WriteLine("Наименование:");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("Автор:");
                        string s2 = Console.ReadLine();
                        Console.WriteLine("Жанр:");
                        string s3 = Console.ReadLine();
                        librarary.Add(s1, s2, s3);
                    }

                    librarary.Sort();
                    librarary.seft_to_file();

                }
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!", "Ошибка");
            }
        }
    }
}
