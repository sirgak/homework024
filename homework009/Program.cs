using System;

namespace homework009
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "ключ";
            int tryCount = 3;

            for (int i=0; i < tryCount; i++)
            {
                Console.Write("пароль: ");
                string userInput=Console.ReadLine();

                if (password == userInput )
                {
                    Console.WriteLine("Секрет ");
                }
                else
                {
                    Console.WriteLine("Попыток осталось " + (tryCount - i - 1));
                }
            }
        }
    }
}
