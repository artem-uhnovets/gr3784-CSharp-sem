// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6

// Console.Clear();
// Console.Write("Введите 3х значное число: ");
// string number = Console.ReadLine();
// int number2 = 0;
// if (number.Length != 3) Console.WriteLine("Введено не 3х значное число!!!");
// number2 = int.Parse(number);
// int ostatok = number2%10;
// Console.WriteLine("Остаток от числа " + number + " равен " + ostatok);

Console.Clear();
Console.Write("Введите 3х значное число: ");
int number = int.Parse(Console.ReadLine());
int ostatok = number%10;
Console.WriteLine("Остаток от числа " + number + " равен " + ostatok);