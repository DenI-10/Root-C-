//Напишите программу, которая
// 1.принимает на вход число N и 
// 2.выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int productnum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked   //проверяет ошибки
        {
            productnum = productnum * i;
        }
    }   
        return productnum;
    }


    Console.Write("Введите целое число: ");
    int number;
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 0)
            Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
        else
            Console.WriteLine("Введено корректные значение. Введите натуральное число.");
    }
    else
        Console.WriteLine("Введено корректные значение. Введите целое число");