// Напишите программу,
// которая принимает на вход два числа
// и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.Write("Введите 1ое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2ое число: ");
int num2 = int.Parse(Console.ReadLine());
int result1 = num1*num1;
int result2 = num2*num2;
if ((result1==num2) || (result2==num1)) Console.WriteLine($"Да, одно число является квадратом другого.");
else Console.WriteLine($"Нет, ни одно из чисел не является квадратом другого.");