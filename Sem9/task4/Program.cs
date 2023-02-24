// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

// int DegreeNumRec(int numberA, int numberB)
// {
//     int result = numberA;
//     if (numberB == 1) return result;
//     else result *= DegreeNumRec(numberA, numberB - 1); 
//     return result;
// }

int DegreeNumRec(int numberA, int numberB)
{
    if (numberB == 1) return numberA;
    else return numberA * DegreeNumRec(numberA, numberB - 1); 
}


int GetNumber(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.Write(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int numberA = GetNumber("Введите число 1ое число - ");
int numberB = GetNumber("Введите число 2ое число - ");
Console.WriteLine($"A = {numberA}; B = {numberB} -> {DegreeNumRec(numberA, numberB)}");