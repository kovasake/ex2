// // 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да 
// // a = 2, b = 10 -> нет 
// // a = 9, b = -3 -> да 
// // a = -3 b = 9 -> нет
// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 	3 -> Среда 
// // 5 -> Пятница

// Console.Clear ();

// Console.Write ("Введите число");

// int num = Convert.ToInt32(Console.ReadLine ());

// int 1 == Понедельник;
// int 2 == Вторник;
// int 3 == Среда;
// int 4 == Четверг;
// int 5 == Пятница;
// int 6 == Суббота;
// int 7 == Воскресенье;

// if (1)

Console.Clear ();
Console.WriteLine ("Введите первое число: ");

int num1 = Convert.ToInt32 (Console.ReadLine);
Console.WriteLine ();

Console.WriteLine ("Введите второе число");

int num2 = Convert.ToInt32 (Console.ReadLine);
Console.WriteLine ();

int squaer = num2 * num2;
Console.WriteLine ($"Result: = {squaer}")

if (squaer == num2);
{
    Console.WriteLine ("Yes");
}
{
    else
    Console.WriteLine ("No");
}