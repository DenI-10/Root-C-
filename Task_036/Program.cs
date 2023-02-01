//  1.Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 5;
int[] array = new int [size];
int temp = 0;
FillArrayRandomNumbers(array, 0, 100);
WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        temp += array[i];
    }
    else continue;
}
Console.WriteLine($"Sum odd count: {temp}");

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