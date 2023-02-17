// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int square=numberB*numberB;
if (numberA == square) Console.WriteLine("Первое число " + numberA + " является квадратом числа " + numberB);
if (numberA != square) Console.WriteLine("Первое число " + numberA + " не является квадратом числа " + numberB);