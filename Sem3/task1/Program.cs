// Задача №17. Напишите программу, 
// которая принимает на вход 
// координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.Clear();
void CheckQuarter(int x, int y)
{
    if (x > 0 & y > 0)
    {
        Console.WriteLine("Точка принадлежит 1 четверти.");
    }
    if (x < 0 & y > 0)
    {
        Console.WriteLine("Точка принадлежит 2 четверти.");
    }
    if (x < 0 & y < 0)
    {
        Console.WriteLine("Точка принадлежит 3 четверти.");
    }
    if (x > 0 & y < 0)
    {
        Console.WriteLine("Точка принадлежит 4 четверти.");
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввод данных от пользователя
int x = GetNum("Введите значение Х ");
int y = GetNum("Введите значение Y ");
// определить четверть
CheckQuarter(x, y);
