// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

string GetNum(string text)
{
    Console.WriteLine(text);
    string number = Console.ReadLine();
    return number;
}

int Result(string number)
{
    int count = number.Length;
    return count;
}

string number = GetNum("Введите число: ");

Console.WriteLine($"{number} -> {Result(number)}");

