//  Напишите программу, 
//  1.которая на вход принимает число (N), 
//  2.а на выходе показывает все чётные числа от 1 до N.
//  Напиши вывод.

//  5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}