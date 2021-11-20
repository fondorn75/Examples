//int[,] table = new int[3, 3];

// void PrintArray(int[,] tabl)
// {
//     for (int i = 0; i < tabl.GetLength(0); i++)
//     {
//         for (int j = 0; j < tabl.GetLength(1); j++)
//         {
//             Console.Write($"{tabl[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }

// void Massive(int[,] tab)
// {
//     for (int i = 0; i < tab.GetLength(0); i++)
//     {
//         for (int j = 0; j < tab.GetLength(1); j++)
//         {
//             tab[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// PrintArray(table);
// Massive(table);
// Console.WriteLine();
// PrintArray(table);

// int[,] image = new int[,]
// {
//     {0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,1,1,1,1,0,0,0,1,1,1,1,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
// };


// void PrintArray(int[,] tabl)
// {
//     for (int i = 0; i < tabl.GetLength(0); i++)
//     {
//         for (int j = 0; j < tabl.GetLength(1); j++)
//         {
//             if (tabl[i, j] == 0) Console.Write($" ");
//             else Console.Write($"*");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {

//     if (image[row, col] == 0)
//     {
//         image[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }

// }

// PrintArray(image);
// FillImage(13,13);
// PrintArray(image);


// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5));



// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

int Fibonacchi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacchi(n - 1) + Fibonacchi(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacchi(i)}");
}
