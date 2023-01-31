// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования

Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int[] CopyArray(int[] array)
{
    int[] copyarr = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        copyarr[index] = array[index];
    }
    return copyarr;
}

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(min, max + 1);
    }
    return arr;
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

//Запрос кол-ва элементов в массиве
int size = GetSize("Введите размер массива");

//Создание массива
int[] array = GetArray(size, 0, 9);

//Скопируйте массив
int[] copyarr = CopyArray(array);
PrintArray(array);
Console.Write($" -> ");
PrintArray(copyarr);