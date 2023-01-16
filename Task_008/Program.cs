//  Напишите программу, 
//  1.которая на вход принимает число (N), 
//  2.а на выходе показывает все чётные числа от 1 до N.
//  Напиши вывод.

//  5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}