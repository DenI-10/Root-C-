﻿// Напиши программу, 
// 1.которая принимает на вход трехзначные число 
// 2. и на выходе показывает последнию цифру этого числа
// 3.вывод результата

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное целое число "); //ввод текста
int number = Convert.ToInt32(Console.ReadLine());
int res = number % 10;
Console.WriteLine($"Последнию цифра {res}");
