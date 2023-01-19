//  Напишите программу, 
//  1.которая на вход принимает два числа
//  2. и выдаёт, 
//  3.какое число большее, 
//  4.а какое меньшее.
//  5. напиши вывод.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число "); //ввод текста
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число "); //ввод текста
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"число {number2} больше числа {number1}");
}