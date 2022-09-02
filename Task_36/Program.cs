// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// массив, заполненный случайными числами.
Console.Write("Введите количество значений в массиве: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало диапозона возможных значений в массиве: ");
int begin = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец диапозона возможных значений в массиве: ");
int end = int.Parse(Console.ReadLine()!);

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
        Console.Write($"{random_arr2[ind2]} ");
        ind2++;
    }
}
int[] array = new int[length];
FillArray(array, begin, end);
PrintArray(array);

// Найдите сумму элементов, стоящих на нечётных позициях.

int UnequalSum (int [] arr3)
{
int index = 1;
int sum = 0;
int num = arr3[index];
while (index <= arr3.Length)
{
    sum = sum + num;
    index = index +2;
}
return (sum);
}
int result = UnequalSum (array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {result}.");
