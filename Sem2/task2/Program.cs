// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100,1000);
Console.WriteLine($"Ваше случайное число {num}");

int num1 = num/100;
Console.WriteLine($"Ваша первая цифра {num1}");

int num2 = num%10;
Console.WriteLine($"Ваша вторая цифра {num2}");

int num3 = num1*10+num2;
Console.WriteLine($"Ваше 2х значное число {num3}");