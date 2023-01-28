// Напишите программу,
// которая по заданному номеру четверти,
// показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
void Value(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("Диапазон координат x > 0 и y > 0");
    }
    if (quarter == 2)
    {
        Console.WriteLine("Диапазон координат x < 0 & y > 0");
    }
    if (quarter == 3)
    {
        Console.WriteLine("Диапазон координат x < 0 & y < 0");
    }
    if (quarter == 4)
    {
        Console.WriteLine("Диапазон координат x > 0 & y < 0");
    }
    if (quarter > 4 || quarter <1)
    {
        Console.WriteLine("Диапазон координат x > 0 & y < 0");
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввод данных от пользователя
int quarter = GetNum("Введите значение четверти ");
// определить четверть
Value(quarter);