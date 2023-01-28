// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// for (int count = 0; count <= number; count++)
// {
//     int summ = 0;
//     summ = summ + count;
// }

// int Summ(int number)
// {
//     Console.Write("Введите число ");
// }

Console.Clear();

int PromptNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetSumm(int number)
{
    int result = 0;
    // for (int i = 1; i <= number; i++) result = result + i;
    for (int i = 1; i <= number; i++)
    {
        result = result + i;
    }
    return result;
}

int number = PromptNumber("Введите число ");
Console.WriteLine($"{number} -> {GetSumm(number)}");