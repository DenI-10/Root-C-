//Напишите программу, 
//1.которая принимает на вход цифру, обозначающую день недели, 
//2.и проверяет, является ли этот день выходным.
//3.напишите вывод

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("Праздник");
	} else {
		Console.Write("Это рабочий день");
	}
} else {
	Console.Write("Введите действительный день от 1 до 7");
}
