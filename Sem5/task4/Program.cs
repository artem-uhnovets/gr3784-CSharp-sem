// Задайте одномер массив из 123 случ чисел
// и найдите количество элементов массива значение
// которых лежат на отрезке от 10 до 99 включительно

Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == (array.Length - 1)) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

int GetSize(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
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

void CheckNum(int[] array, int start, int end)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] >= start && array[index] <= end) count++;
    }
    if (count == 0) Console.WriteLine($"Искомый диапазон элементов от {start} до {end} НЕ имеется в массиве");
    else Console.WriteLine($"Кол-во элементов массива в диапазоне от {start} до {end} равно {count} раз(а).");
}

int size = GetSize("Введите размер массива: ");
int[] array = GetArray(size, 0, 999);
Console.WriteLine("Случайно созданный массив");
// Console.WriteLine(String.Join(", ", array));
PrintArray(array);
CheckNum(array, 10, 99);

// Код был скопирован из мною написанного task3, там count не считался если искомое число было в 0-ом индексе, а здесь считает
// Введите размер массива: 
// 25
// Случайно созданный массив
// [49, 49, 505, 749, 211, 748, 956, 189, 484, 379, 409, 682, 365, 120, 647, 327, 646, 855, 987, 823, 217, 169, 275, 407, 120, 811]
// Кол-во элементов массива в диапазоне от 10 до 99 1 раз(а).