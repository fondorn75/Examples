﻿using System;

namespace Examples006_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 6;
            int d = 8;
            int e = 4;
            int max = 0;
            if (a > max) max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;

            Console.WriteLine("max = " + max);
         
        }
    }
}