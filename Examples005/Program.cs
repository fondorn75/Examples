using System;

namespace Examples005
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите имя: ");
           string username = Console.ReadLine();
           if (username.ToLower() == "маша")
           {
               Console.WriteLine("Привет, красотка!");
           }
           else
           {
               Console.WriteLine("Привет, " + username);
           }

        }
    }
}
