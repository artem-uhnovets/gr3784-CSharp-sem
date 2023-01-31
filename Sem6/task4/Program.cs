// Выведите первые N чисел последовательности фибоначи

Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"{array[i]}, ");
        else if (i == (array.Length - 1)) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int[] GetArray(int size)
{
    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int index = 2; index < size; index++)
    {
        arr[index] = arr[index-1] + arr[index-2];
    }
    return arr;
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int number = GetNum("Введите число");
int[] arr = GetArray(number);
PrintArray(arr);