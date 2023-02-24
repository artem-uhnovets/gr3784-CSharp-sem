// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

// int SummNumRec(int number)
// {
//     int result = number % 10;
//     if (number / 10 == 0) return result;
//     else result += SummNumRec(number / 10);
//     return result;
// }

int SummNumRec(int number)
{
    if (number / 10 == 0) return number % 10;
    else return number % 10 + SummNumRec(number / 10);
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int number = GetNumber("Введите число - ");
Console.WriteLine($"{number} -> {SummNumRec(number)}");