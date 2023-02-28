// Составить частотный словарь элементов двумерного массива.
// Только для цифр 1 - 9.
// Усложненная для всех чисел.

Console.Clear();

int FindDigit(int[,] array, int digit)
{
    int[,] countArray = new int[(array.GetLength(0) * array.GetLength(1)), 2];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == digit)
            {
                count++;
            }
        }
    }
    return count;
}

int[,] FreqDigit(int[,] array)
{
    Console.WriteLine();
    int[,] countArray = new int[(array.GetLength(0) * array.GetLength(1)), 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            countArray[(i + j + (i * (array.GetLength(1) - 1))), 0] = array[i, j];
            countArray[(i + j + (i * (array.GetLength(1) - 1))), 1] = FindDigit(array, array[i, j]); 
        }
    }
    return countArray;
}

void CheckElementArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        if (i == 0)
        {
            Console.WriteLine("{0} встречается {1} раз(а)", array[i, 0], array[i, 1]);
            continue;
        }
        for (int k = 0; k < i; k++)
        {
            if (array[k, 0] == array[i, 0])
            {
                count++;
                continue;
            }
        }
        if (count != 0) continue;
        else Console.WriteLine("{0} встречается {1} раз(а)", array[i, 0], array[i, 1]);

    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + $"\t");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    string size = Console.ReadLine();
    while (int.TryParse(size, out _) == false || String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.WriteLine(text); size = Console.ReadLine(); }
    return int.Parse(size);
}

int sizeRow = GetSize("Введите кол-во строк ");
int sizeColumn = GetSize("Введите кол-во столбцов ");
int[,] array = GetArray(sizeRow, sizeColumn, 0, 100);
PrintArray(array);
int[,] countArray = FreqDigit(array);
CheckElementArray(countArray);

// {1, 9, 9, 0, 2, 8, 0, 9}    0 вcтречается 2 раза
//                             1 встречается 1 раз
//                             2 встречается 1 раз
//                             8 встречается 1 раз
//                             9 встречается 3 раза

// 1, 2, 3                        1 встречается 3 раза
// 4, 6, 1                        2 встречается 2 раза
// 2, 1, 6                        3 встречается 1 раз
//                                4 встречается 1 раз
//                                6 встречается 2 раза

// void FreqDigit(int[,] array)
// {
//     Console.WriteLine();
//     for (int digit = 0; digit <= 9; digit++)
//     {
//         FindDigit(array, digit);
//     }

// }

// int FindDigit(int[,] array, int digit)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == digit)
//             {
//                 count++;
//             }
//         }
//     }
//     if (count > 0) Console.WriteLine($"{digit} встречается {count} раз(а).");
//     return count;
// }