//Напишите программу, 
//1.которая принимает на вход трёхзначное число 
//2.и на выходе показывает вторую цифру этого числа.
//3.напишите вывод

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехначное целое число "); //ввод текста
try {
	int Value= Convert.ToInt32(Console.ReadLine());
	int Length = Value.ToString().Length;
	if (Length == 3) {
		int result = ( Value/10 ) % 10;
		Console.WriteLine($"Вторая цифра {result}");
	} else {
		Console.WriteLine("Нет трехзначного числа");
	}
} catch (Exception e) {
	Console.WriteLine(e.Message);
}
