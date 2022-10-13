// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве не существует

// ....

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
}
void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($" {ar[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();

Console.Write("Введите индекс строки от 0 до 5: ");
int k = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите индекс столбца от 0 до 5: ");
int l = Convert.ToInt32(Console.ReadLine());

int m = 5;
int n = 6;   
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

if (k >= array.GetLength(0) || l >= array.GetLength(1))
{
    Console.Write($"Элемент инексами [{k}, {l}] не существует в этом массиве");
}
else
{
    Console.WriteLine($"Элемент на позиции [{k}, {l}] = {array[k-1, l-1]} ");
}
