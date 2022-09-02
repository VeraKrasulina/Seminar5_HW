// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Задайте массив заполненный случайными положительными трёхзначными числами

Console.WriteLine("Введите количество значений в массиве: ");
int length = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите начало диапозона возможных значений в массиве: ");
// int begin = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите конец диапозона возможных значений в массиве: ");
// int end = int.Parse(Console.ReadLine()!);

void FillArray(int[] random_arr1, int begin, int end)
{
    int lgth1 = length;
    int ind1 = 0;
    while (ind1 < lgth1)
    {
        random_arr1[ind1] = new Random().Next(begin, end);
        ind1++;
    }
}

void PrintArray(int[] random_arr2)
{
    int legth2 = random_arr2.Length;
    int ind2 = 0;
    Console.WriteLine("Печать массива:");
    while (ind2 < legth2)
    {
        Console.Write($"{random_arr2[ind2]}, ");
        ind2++;
    }
}
int[] array = new int[length];
FillArray(array, 99, 1000);
PrintArray(array);

// покажет количество чётных чисел в массиве

int Counter(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        count += number % 2 == 0 ? 1 : 0;
    }
    return count;
}
int result = Counter(array);
Console.WriteLine();
Console.WriteLine($"В массиве {result} четных чисел.");