// int Sum(int a)
// {
//     return a + 10;
// }

// int Mult(int a)
// {
//     return a * a;
// }

// void Calc(int x, Func<int, int> f)
// {
//     Console.WriteLine(f(x));
// }

// Calc(20, Mult);

// void Print<T>(T a)
// {
//     Console.WriteLine(a);
// }

// int Pow(int a) { return a * a; }
// bool IsOdd(int a) { return a % 3 == 0; }

// Array.ForEach(Enumerable.Range(10, 20)
//                         .Where(IsOdd)
//                         .Select(Pow)
//                         .Select(e => Math.Log(e))
//                         .ToArray(), Print);

void A()
{
    for (int i = 0; i < 100; i++)
    {
        Console.Write("* ");
        Thread.Sleep(10);
    }
}
void B()
{
    for (int i = 0; i < 100; i++)
    {
        Console.Write("- ");
        Thread.Sleep(10);
    }
}

new Thread(A).Start();
new Thread(B).Start();

for (int i = 0; i < 100; i++)
{
    Console.Write("+ ");
    Thread.Sleep(10);
}

