// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае если это невозможно, программа должна вывести соообщение для пользователя.

Console.Clear();

int[,] ModifArray(int[,] array)
{
    int[,] arrayModif = new int[array.GetLength(1), array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            arrayModif[i, j] = array[j, i];
        }
    }
    return arrayModif;
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
    int size = int.Parse(Console.ReadLine());
    return size;
}

int sizeRow = GetSize("Введите кол-во строк ");
int sizeColumn = GetSize("Введите кол-во столбцов ");
int[,] array = GetArray(sizeRow, sizeColumn, 0, 100);
PrintArray(array);
array = ModifArray(array);
PrintArray(array);