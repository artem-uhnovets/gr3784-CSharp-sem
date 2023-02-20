// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении, которых расположен наименьший элемент массива.

Console.Clear();

int[,] ModifArray(int[,] array)
{
    int[,] arrayModif = new int[(array.GetLength(0) - 1), (array.GetLength(1) - 1)];
    int min = array[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьший элеммент {min} находится в индексах {minI} и {minJ}.");
    for (int i = 0; i < (array.GetLength(0) - 1); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            // int countI = 0;
            // if (i == minI)
            // {
            //     if (i == minI && j == minJ) arrayModif[i, j] = array[i + 1, j + 1];
            //     else if (countI != 0) arrayModif[i, j] = array[i + 1, j + 1];
            //     else arrayModif[i, j] = array[i + 1, j];
            //     countI = countI + 1;
            //     Console.WriteLine($"countI = {countI}");
            // } 
            // else if (countI != 0) 
            // {
            //     if (j == minJ) arrayModif[i, j] = array[i + 1, j + 1];
            //     else arrayModif[i, j] = array[i + 1, j];
            // }
            // else if (j == minJ) arrayModif[i, j] = array[i, j + 1];
            // else arrayModif[i, j] = array[i, j];
            // int countI = 0;
            // int countJ = 0;

            // if (j >= minJ)
            // {
            //     if ((j >= minJ) && (i >= minI)) arrayModif[i, j] = array[i + 1, j + 1];
            //     else arrayModif[i, j] = array[i, j + 1];
            // }
            // else if (i >= minI)
            // {
            //     if ((j >= minJ) && (i >= minI)) arrayModif[i, j] = array[i + 1, j + 1];
            //     else arrayModif[i, j] = array[i + 1, j];
            // }
            // else arrayModif[i, j] = array[i, j];

            if ((j >= minJ) && (i >= minI)) arrayModif[i, j] = array[i + 1, j + 1];
            else if (j >= minJ) arrayModif[i, j] = array[i, j + 1];
            else if (i >= minI) arrayModif[i, j] = array[i + 1, j];
            else arrayModif[i, j] = array[i, j];
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
int[,] array = GetArray(sizeRow, sizeColumn, 0, 10);
PrintArray(array);
array = ModifArray(array);
PrintArray(array);