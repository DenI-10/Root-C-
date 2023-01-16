// Напиши программу, которая 
// 1.на вход принимает два числа 
// 2.и проверяет, 
// 3.являеться ли первое число квадратом второго.
// 4.вывод результата.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("введите целое число 1: " );
int number = Convert.ToInt32(Console.ReadLine());// 3434
Console.WriteLine("введите целое число 2: " );
int number1 = Convert.ToInt32(Console.ReadLine());// 3434
if (number1 * number1 == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
