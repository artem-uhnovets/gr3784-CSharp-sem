// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде ранобедренного треугольника.

Console.Clear();

int[,] ModifArray(int[,] array)
{
    int[,] modifArray = new int[array.GetLength(0), ((array.GetLength(1) - 1) * 2 + 1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < ((array.GetLength(1) - 1) * 2 + 1); j++)
        {
            if (i == 0)
            {
                if (j == (array.GetLength(1) - 1)) modifArray[i, j] = array[i, 0];
                else modifArray[i, j] = 0;
            }
            else if (i == (array.GetLength(0) - 1))
                {
                    if (j == 0 || j == (modifArray.GetLength(1)-1)) modifArray[i, j] = 1;
                    else modifArray[i, j] = modifArray[i - 1, j - 1] + modifArray[i - 1, j + 1];
                }
            else if (j == 0 || j == (modifArray.GetLength(1)-1)) modifArray[i, j] = 0;
            else modifArray[i, j] = modifArray[i - 1, j - 1] + modifArray[i - 1, j + 1];
        }
    }
    return modifArray;
}

int Factorial(int number)
{
    int factorial = 1;
    for (int index = 0; index <= number; index++)
    {
        factorial *= index;
        if (factorial == 0) factorial = 1;
    }
    return factorial;
}

// void PrintArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] != 0) Console.Write(array[i, j] + $"\t");
//         }
//         Console.WriteLine();
//     }
// }

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintArray2(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write("{0,4}", array[i, j]);
            else Console.Write("{0,4}", array[i, j].ToString(" "));
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int size)
{
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j == 0 || i == j) array[i, j] = 1;
            else if (j > i) array[i, j] = 0;
            else array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
        }
    }
    return array;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int size = GetSize("Сколько первых строк треугольника Паскаля вывести?");
int[,] array = GetArray(size);
PrintArray(array);
array = ModifArray(array);
PrintArray2(array);