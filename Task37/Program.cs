/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

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
        Console.Write(col[pos]);
        if (pos < col.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] ProductOfNumbers(int[] arrayProduct)
{
    int lengthResult = 0;
    if (arrayProduct.Length % 2 == 0)
    {
        lengthResult = arrayProduct.Length / 2;
    }
    else
    {
        lengthResult = arrayProduct.Length / 2 + 1;
    }
    int[] result = new int[lengthResult];
    for (int i = 0; i < arrayProduct.Length / 2; i++)
    {
        result[i] = arrayProduct[i] * arrayProduct[(arrayProduct.Length - 1) - i];
    }
    if (arrayProduct.Length % 2 != 0)
    {
        result[lengthResult - 1] = arrayProduct[arrayProduct.Length / 2];
    }
    return result;
}

int[] array = new int[5];
FillArray(array);
Console.Write("Случайный массив -> ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int[] massiveResult = ProductOfNumbers(array);
Console.Write("Массив из первой и последней пар чисел -> ");
PrintArray(massiveResult);