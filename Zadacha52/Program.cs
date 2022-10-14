// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5);
        }
}
void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($" {ar[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

int[,] array2 = new int[3, 4];

FillArray(array2);
PrintArray(array2);

int sum = 0;



for (int j = 0; j < array2.GetLength(1); j++)
{

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        sum = sum + array2[i, j];

        if (i == array2.GetLength(0) - 1)
        {
            double rez = sum / array2.GetLength(0);

            Console.Write($" {rez} ");
        }


    }

}

// // .........


// void FillArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Array[i, j] = new Random().Next(1, 4);
//         }
// }
// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($" {Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Clear();

// int[,] Array1 = new int[3, 4];
// double[] Sum = new double[4];

// FillArray(Array1);
// PrintArray(Array1);

// for (int i = 0; i < Array1.GetLength(0); i++)
// {
//     for (int j = 0; j < Array1.GetLength(1); j++)
//     {
//         Sum[j] = Sum[j] + Array1[i, j];
//     }
// }

// Console.WriteLine("Среднее арифметическое каждого столбца:");

// for (int i = 0; i < Array1.GetLength(0); i++)
// {
//     if (i == Array1.GetLength(0) - 1)
//     {
//         Console.Write($" {Sum[i] / Array1.GetLength(0)}. ");
//     }
//     else
//     {
//         Console.Write($" {Sum[i] / Array1.GetLength(0)}; ");
//     }
// }