// Решение в группах задач:
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

// Решение в группах задач:
//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// Console.Clear();

// int GetNum(string text)
// {
//     Console.WriteLine(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int Result (int number)
// {
//     int result = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }
// int number = GetNum("Введите число ");
// Console.WriteLine($"{number} -> {Result(number)}");


Console.Clear();

int[] arr = new int[8];
// Ввод нового массива с размерностью 8 индексов

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);
        if (i == 0) Console.Write($"[{array[i]},");
        else if (i == 7) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]},");
    }
}

PrintArray(arr);