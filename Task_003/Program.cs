// // 1.Напиши программу, которая будет выдовать
// // 2.названия дня недели по задоному номеру
// // 3.вывод результата 

// // 3 -> Среда
// // 5 -> Пятница

Console.WriteLine ("введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
    Console.WriteLine("Это Понедельник");
else if (a == 2)
    Console.WriteLine("Это Вторник");
else if (a == 3)
    Console.WriteLine("Это Среда");
else if (a == 4)
    Console.WriteLine("Это Четверг");
else if (a == 5)
    Console.WriteLine("Это Пятница");
else if (a == 6)
    Console.WriteLine("Это Суббота");
else if (a == 7)
    Console.WriteLine("Это Воскресенье");
else Console.WriteLine("Введенно не коректное значение");