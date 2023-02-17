// Напишите программу, 
// которая принимает на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Clear();
// int num = new Random().Next(1,10000);
// Console.WriteLine($"Ваше случайное число {num}");
// int result1 = num%7;
// int result2 = num%23;
// if (result1 == 0 && result2 == 0) Console.WriteLine($"Число {num} кратно 7 и 23.");
// else Console.WriteLine($"Число {num} НЕ кратно 7 и 23.");

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result1 = num%7;
int result2 = num%23;
if (result1 == 0 && result2 == 0) Console.WriteLine($"Число {num} кратно 7 и 23.");
else Console.WriteLine($"Число {num} НЕ кратно 7 и 23.");