// System.Console.WriteLine("Введите первое целое число");
// int num1 = Convert.ToInt32( Console.ReadLine() );
// System.Console.WriteLine("Введите второе целое число");
// int num2 = Convert.ToInt32( Console.ReadLine() );
// if (num2 * num2 == num1)
// {
//     System.Console.WriteLine("да");
// }
// else
//     System.Console.WriteLine("нет");


// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N. 
// Примеры 
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Введите  целое число");
// int num = Convert.ToInt32( Console.ReadLine() );
// int i = -num;
// while(i < num)
// {
//     Console.Write(i + ", ");
//     i = i + 1;
// }
// System.Console.WriteLine(i);


// Задание 3*. Работа в сессионных залах
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


// System.Console.WriteLine("Введите целое трехзначное число");
// int nam = Convert.ToInt32( Console.ReadLine() );
// int i1 = nam / 100;
// double i2 = nam % 10;
// double sum = i1+i2;
// System.Console.WriteLine(sum);

// ДЗ Знакомство с языками программирования (семинары)
// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
Console.WriteLine("да");
else
Console.WriteLine("нет");

