// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

void PrintNaturalNumber(int number)
{
    if (number == 1) Console.Write("1");
    else { PrintNaturalNumber(number - 1); Console.Write($", {number}"); }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int number = GetNumber("Введите кол-во чисел для вывода");
PrintNaturalNumber(number);