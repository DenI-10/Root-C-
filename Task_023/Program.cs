// Напишите программу, 
// 1.которая принимает на вход число (N) 
// 2.и выдаёт таблицу кубов чисел от 1 до N.
// 3.напишите вывод

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}