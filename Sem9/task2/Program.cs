// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

void PrintNaturalNumber(int numberLower, int numberUpper)
{
    if (numberUpper == numberLower) Console.Write($"{numberLower}");
    else { PrintNaturalNumber(numberLower, numberUpper - 1); Console.Write($", {numberUpper}"); }
}

int GetNumber(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.Write(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int numberM = GetNumber("Введите начало промежутка чисел - ");
int numberN = GetNumber("Введите конец промежутка - ");
Console.Write("M = {0}; N = {1} -> ", numberM, numberN);
PrintNaturalNumber(numberM, numberN);