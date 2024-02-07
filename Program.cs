// _____________________________________________________________________________________________________________
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

// // Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
  Console.Write("Вы ошиблись! Введите координату X: ");
  x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
  Console.Write("Вы ошиблись! Введите координату Y: ");
  y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
  Console.WriteLine("1");
else if (x < 0 && y > 0)
  Console.WriteLine("2");
else if (x < 0 && y < 0)
  Console.WriteLine("3");
else
  Console.WriteLine("4");

// Задача 3:  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите целое число от 10 до 99 включительно: ");
int in_num = int.Parse(Console.ReadLine()!);
if (in_num < 10 || in_num > 99) {
    Console.WriteLine("Ваше число не входит в заданый диапазон");
} else {
    int first_num = in_num / 10;
    int second_num = in_num % 10;
    if (first_num > second_num) {
        Console.WriteLine($"{first_num} первая цифра больше");
    } else if (first_num < second_num) {
        Console.WriteLine($"{second_num} вторая цифра больше");
    } else {
        Console.WriteLine($"{second_num} и {first_num} равны");
    }
}

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
