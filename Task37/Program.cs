/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] array = new int[6];

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 9);
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
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

void ProductOfNumbers(int[] collection)
{
    for (int i = 0; i < collection.Length - i; i++)
    {
        collection[i] = collection[i] * collection[collection.Length - 1 - i];
    }
}

void PrintArray1(int[] col1)
{
    Console.Write("[");
    for (int pos1 = 0; pos1 < col1.Length - pos1; pos1++)
    {
        Console.Write(col1[pos1]);
        if (pos1 < col1.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

FillArray(array);
Console.WriteLine("Случайный массив ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
ProductOfNumbers(array);
Console.WriteLine("Массив из первой и последней пар чисел ");
PrintArray1(array);