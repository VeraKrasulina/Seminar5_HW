// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задайте массив вещественных чисел.
Console.Write("Введите количество значений в массиве: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец диапозона возможных значений в массиве: ");
int end = Convert.ToInt32(Console.ReadLine()!);

double[] array = new double[length];
Random rand = new Random();
for (int ind1 = 0; ind1 < length; ind1++)
{
    array[ind1] = rand.NextDouble() * end;
}


void PrintArray(double[] random_arr2)
{
    int legth2 = random_arr2.Length;
    int ind2 = 0;
    Console.WriteLine("Печать массива:");
    while (ind2 < legth2)
    {
        Console.Write($"{Math.Round(random_arr2[ind2], 2)} ");
        ind2++;
    }
}

PrintArray(array);

// Максимальное и минимальное значение
double Min (double[] array)
{
double min = array[0];
int ind =0;
while (ind < array.Length)
{
if (min > array[ind])
{
    min = array[ind];
}
ind++;
}
return min;
}

double Max (double[] array)
{
double max = array [0];
int ind =0;
while (ind < array.Length)
{
if (max < array[ind])
{
    max = array[ind];
}
ind++;
}
return max;
}

// Найдите разницу между максимальным и минимальным элементов массива.
double result = Max(array) - Min(array);
Console.WriteLine();
Console.WriteLine($"Максимальное значение в массиве - {Math.Round(Max(array), 2)}, минимальное - {Math.Round(Min(array), 2)}. Их разница - {Math.Round(result, 2)}");