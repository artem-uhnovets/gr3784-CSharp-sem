// Расстояние между 2мя точками на плоскости
// в зависимости от координат
// AB = √(xb - xa)2 + (yb - ya)2

//MathF.Pow(x,y) метод возводит x в степень y, преобразует в тип float
//Sqrt:.Sqrt (5.25)

Console.Clear();
float Distance(float x1, float y1, float x2, float y2)
{
    float result = MathF.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)));
    Console.WriteLine($"Расстояние между точками равно {result}");
    return result;
}

float GetNum(string text)
{
    Console.WriteLine(text);
    float num = float.Parse(Console.ReadLine());
    return num;
}

// ввод данных от пользователя
float x1 = GetNum("Введите значение Х1 ");
float y1 = GetNum("Введите значение Y1 ");
float x2 = GetNum("Введите значение Х2 ");
float y2 = GetNum("Введите значение Y2 ");

// определить четверть
Distance(x1, y1, x2, y2);