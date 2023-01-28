// замена элементов массива
// положительные элементы на отрицательные
// и наоборот

Console.Clear();

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

int[] InvertArray(int[] array)
{
    int arrlen = array.Length;
    int[] arrInvert = new int[arrlen];
    for (int i = 0; i < arrlen; i++)
    {
        arrInvert[i] = -1 * array[i];
    }
    return arrInvert;
}

int[] array = GetArray(12, -999, 999);
Console.WriteLine(String.Join(", ", array));
int[] arrayInvert = InvertArray(array);
Console.WriteLine(String.Join(", ", arrayInvert));