// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A[i,j] = i+j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + $"\t"); 
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
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
int[,] array = GetArray(sizeRow, sizeColumn);
PrintArray(array);