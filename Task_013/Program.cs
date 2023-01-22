// Напишите программу, 
//1.которая выводит третью цифру заданного числа или сообщает,
//2.что третьей цифры нет.
//3.напишите вывод

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число:");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) {
	while (Value2 > 999)
	{
		Value2 = Value2 / 10;
	}
	int result = Value2 % 10;
	Console.WriteLine("Третья цифра" + result);
} else {
	Console.WriteLine("Число содержит менее 3-ч цифр");
}
