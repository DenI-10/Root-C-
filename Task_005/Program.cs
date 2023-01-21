// Напиши программу, 
// 1.которая на вход принимает одно число (N),
// 2. а на выходе показывает все целые числа в промежутке от -N до N.
// 3. вывод результата

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = -num;
    while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.Write("Число должно быть больше нуля");
}
