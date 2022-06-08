/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[4];

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] col)
{
    Console.Write("Случайный массив: [");
    for (int pos = 0; pos < col.Length; pos++)
    {
        if (pos < col.Length - 1)
        {
            Console.Write($"{col[pos]}, ");
        }
        else
        {
            Console.Write(col[pos]);
        }
    }
    Console.Write("]");
}

int IndexOf(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int evennumber = IndexOf(array);

Console.Write($"Колличество четных чисел в массиве: {evennumber}");