﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Clear ();
Console.Write ("Введите число");

int num = Convert.ToInt32(Console.ReadLine ());

int result = num *num;
Console.WriteLine ($"Результат:  + {result}");

if (num == result)
{
    Console.Write ("Yes");
}
else
{
    Console.Write ("No");
}