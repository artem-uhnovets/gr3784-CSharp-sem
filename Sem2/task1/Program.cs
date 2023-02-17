// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10,100);
int num1 = num/10;
int num2 = num%10;
int max = num1;
Console.WriteLine("Первое число равно " + num1);
Console.WriteLine("Второе число равно " + num2); // Console.WriteLine($"Второе число равно {num2}");
if (num2>max)
{
    max = num2;
    Console.WriteLine($"В числе {num} максимальная цифра равна {max}");
}
else
{
    Console.WriteLine(max);
}