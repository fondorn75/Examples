using System;
//Квадратное уравнение — это ax^2 + bx + c = 0, где a — первый или старший коэффициент, не равный нулю, b — второй коэффициент, c — свободный член.
// Чтобы определить, сколько корней имеет уравнение, нужно обратить внимание на дискриминант.
//Чтобы его найти, берем формулу: D = b2 − 4ac. 
//А вот свойства дискриминанта:
// если D < 0, корней нет;
// если D = 0, есть один корень;
// если D > 0, есть два различных корня.

//int x = 1;


void Diskriminant(int a, int b, int c)
{
    double d = 0;
    double x1 = 0;
    double x2 = 0;
    d = (b * b) - 4 * (a * c);
    if (d < 0)
    {
        Console.WriteLine("Дискриминант = " + d);
        Console.WriteLine("Корней нет.");
    }
    else if (d == 0)
    {
        Console.WriteLine("Дискриминант = " + d);
        Console.WriteLine("есть один корень");
        x1 = -b + (Math.Sqrt(d) / 2 * a);
        x1 = -b - (Math.Sqrt(d) / 2 * a);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
    else if (d > 0)
    {
        Console.WriteLine("Дискриминант = " + d);
        Console.WriteLine("есть два различных корня");
        x1 = -b + (Math.Sqrt(d) / 2 * a);
        x1 = -b - (Math.Sqrt(d) / 2 * a);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }

}

Diskriminant(0, 2, 1);