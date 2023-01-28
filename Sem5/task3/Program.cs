// Напишите программу подтверждения наличия определенного числа
// в массиве

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

void CheckNum(int[] array)
{
    Console.WriteLine("Введите число для проверки наличия в массиве:");
    int number = int.Parse(Console.ReadLine());
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (number == array[index]) count++;
    }
    if (count == 0) Console.WriteLine($"Число {number} НЕ имеется в массиве");
    else Console.WriteLine($"Число {number} имеется в массиве в {count} раз(а).");
}

int size = GetSize("Введите размер массива: ");
int[] array = GetArray(size, 0, 20);
Console.WriteLine("Случайно созданный массив");
// Console.WriteLine(String.Join(", ", array));
PrintArray(array);
CheckNum(array);

// Если проверямое число находится в 0-ом индексе,то почему-то не считает его в count

// Введите размер массива: 
// 20
// Случайно созданный массив
// [2, 2, 18, 10, 9, 14, 10, 3, 15, 2, 1, 3, 17, 10, 9, 1, 8, 14, 14, 19, 6]
// Введите число для проверки наличия в массиве:
// 2
// Число 2 имеется в массиве в 2 раз(а)

// Введите размер массива: 
// 20
// Случайно созданный массив
// [12, 12, 16, 3, 9, 3, 20, 9, 1, 11, 13, 9, 20, 15, 20, 13, 4, 0, 2, 5, 11]
// Введите число для проверки наличия в массиве:
// 11
// Число 11 имеется в массиве в 2 раз(а).