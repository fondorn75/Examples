using System;

namespace examples003
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1, 10);
            int numberB = new Random().Next(1, 10);
            Console.WriteLine(numberA);
            Console.WriteLine(numberB);
            int result = numberA + numberB;
            Console.WriteLine(result);
        }
    }
}
