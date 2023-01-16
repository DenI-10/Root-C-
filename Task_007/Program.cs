// Напиши программу, 
// 1.которая принимает на вход трехзначные число 
// 2. и на выходе показывает последнию цифру этого числа
// 3.вывод результата

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
