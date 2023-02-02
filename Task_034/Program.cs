// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 5;
int[] array = new int [size];
int count = 0;
FillArrayRandomNumbers(array, 99, 1000);
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0)
    {
        count++;
    }
    else continue;
}
Console.WriteLine($"Колличество четных чисел: {count}");

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
