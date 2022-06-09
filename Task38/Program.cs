/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = new double[6];

void FillArray(double[] array)
{
    var RandomNumbers = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(RandomNumbers.NextDouble() * 100, 2);
    }
}

void PrintArray(double[] col)
{
    Console.Write("Случайный массив: [ ");
    for (int pos = 0; pos < col.Length; pos++)
    {
        if (pos < col.Length - 1)
        {
            Console.Write($"{col[pos]} | ");
        }
        else
        {
            Console.Write(col[pos]);
        }
    }
    Console.Write(" ]");
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
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
PrintArray(array);
Console.WriteLine();

double max = MaxNumber(array);
double min = MinNumber(array);
double dif = max - min;

Console.WriteLine($"Максимальный элемент массива: {max}; минимальный {min}. Разница между ними: {dif}.");