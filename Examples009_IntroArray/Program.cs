using System;

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] massive_numbers = { 12, 2, 8, 11, 423, 22, 24, 15, 6 };

// int max = Max(Max(massive_numbers[0], massive_numbers[1], massive_numbers[2]),
//               Max(massive_numbers[3], massive_numbers[4], massive_numbers[5]),
//               Max(massive_numbers[6], massive_numbers[7], massive_numbers[8]));

// Console.WriteLine(max);

// int[] array = { 21, 24, 32, 34, 25, 64, 45, 87 };

// int n = array.Length;

// int find = 45;

// int index = 0;

// while (index < n)
// {
//     if (find == array[index])
//     {
//         Console.WriteLine(index);
//     }

//     index++;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;

    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int ArrayOff (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(find == collection[index])
        {
            position = index;
            break;
        }

        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = ArrayOff(array, 44);
Console.WriteLine(pos);