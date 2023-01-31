// Переверните одномерный массив
// Первый элемент станет последним, последний первым
// второй предпоследним и т.д.
// [1, 2, 3] -> [3, 2, 1]

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

int[] InvertArray(int[] array)
{
    int[] reverse = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        reverse[index] = array[array.Length - index -1];
    }
    return reverse;
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

//Переверните массив
int[] reversearray = InvertArray(array);
PrintArray(array);
Console.Write($" -> ");
PrintArray(reversearray);