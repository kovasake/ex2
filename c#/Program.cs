// // // Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// // // Например:
// // // 4 -> 16 
// // // -3 -> 9 
// // // -7 -> 49

// // Console.Clear ();
// // Console.Write ("Введите число");

// // int num = Convert.ToInt32(Console.ReadLine ());

// // int result = num *num;
// // Console.WriteLine ($"Результат:  + {result}");

// // if (num == result)
// // {
// //     Console.Write ("Yes");
// // }
// // else
// // {
// //     Console.Write ("No");
// // }

// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Clear ();

// int a, b;

// Console.WriteLine (" Введите первое число: ");
// a = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine (" Введите второе число: ");
// b = Convert.ToInt32(Console.ReadLine ());

// bool OP = a > b;
// bool OP2 = a == b;
// bool OP3 = a < b;

// if (OP)
// {
//     Console.WriteLine($"Число {a} больше чем {b}");
// }
// else if (OP2)
// {
//     Console.WriteLine ($"Число {a} равняется числу {b}");
// }
// else
// {
//     Console.WriteLine ($"Число {a} меньше  чем число {b}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Clear ();
// Console.WriteLine (" Введите первое число: ");
// int numA = int.Parse (Console.ReadLine ());

// Console.WriteLine (" Введите второе число: ");
// int numB = int.Parse (Console.ReadLine ());

// Console.WriteLine (" Введите третье число: ");
// int numC = int.Parse (Console.ReadLine ());

// int max = numA;
// if (numA > max) max = numA;
// if (numB > max) max = numB;
// if (numC > max) max = numC;
// Console.Write (" Ваше максимальное число: ");
// Console.Write (max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Clear ();
// Console.WriteLine ("Напишите число");
// int num = int.Parse (Console.ReadLine () ?? "0" );

// if (num % 2 == 0) Console.WriteLine (" Четное");
// else Console.WriteLine ("Нечетное ");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}
if (not)
{
Console.WriteLine("Нет чётных чисел!");
}