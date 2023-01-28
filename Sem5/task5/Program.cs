// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем считаем первый и последний элементы, 
// второй и предпоследний и т.д.
// Результат запишите в новом массиве.

Console.Clear();

int[] MultiplicationNewArray(int[] array)
{
    int newarrlen = array.Length / 2 + array.Length % 2;
    int[] newarray = new int[newarrlen];
    for (int index = 0; index < newarrlen; index++)
    {
        if (index == (array.Length - 1 - index) && array[index] == array[(array.Length - 1 - index)]) newarray[index] = array[index];
        else newarray[index] = array[index] * array[(array.Length - 1 - index)];
    }
    return newarray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
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

int size = GetSize("Введите размер массива:");
int[] array = GetArray(size, 0, 11);
PrintArray(array);
int[] newarray = MultiplicationNewArray(array);
PrintArray(newarray);