/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-99, 99);
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

int SumIndexElements(int[] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + collection[i];
        }
    }
    return sum;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int sumElements = SumIndexElements(array);

Console.WriteLine($"Сумма элементов массива, стоящих под нечетным индексом = {sumElements}");