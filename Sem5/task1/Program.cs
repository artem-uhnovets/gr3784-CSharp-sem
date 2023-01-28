// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных 
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

Console.Clear();
int GetSumPlusOrMinus(int[] arr, bool positive)
{
    int result = 0;
    int size = arr.Length;
    for (int index = 0; index < size; index++)
    {
        if ((arr[index] > 0 && positive == true) || (arr[index] < 0 && positive == false))
        {
            result = result + arr[index];
        }

    }
    return result;
}

int[] GetArray(int size, int min, int max)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(min, max + 1);
    }
    return emptyArray;
}

// генерируем массив
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

// сумма положительных чисел
int sumPlusNum = GetSumPlusOrMinus(array, true);

// сумма отрицательных чисел
int sumMinusNum = GetSumPlusOrMinus(array, false);
Console.WriteLine($"Summ of positive numbers are {sumPlusNum}, summ of negative numbers are {sumMinusNum}");