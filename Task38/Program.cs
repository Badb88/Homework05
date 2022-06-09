/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] array = new int[5];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {

            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

FillArray(array);
int max = MaxNumber(array);
int min = MinNumber(array);
int dif = max - min;
PrintArray(array);
Console.WriteLine($"Максимальный элемент массива: [{max}]; минимальный [{min}]. Разница между ними: {dif}.");