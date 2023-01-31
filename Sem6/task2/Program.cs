// принимает на вход 3 числа
// и проверяет может ли существовать треугольник с этими числами
// Каждая сторона треугольника меньше суммы двух других сторон
// AB < BC + AC
// BC < AB + AC
// AC < AB + BC

Console.Clear();

void CheckTriangle(int numberA, int numberB, int numberC)
{
    if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB) Console.WriteLine("Треугольник может существовать");
    else Console.WriteLine("Треугольник НЕ может существовать");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = GetNum("Введите 1-ое число");
int numberB = GetNum("Введите 2-ое число");
int numberC = GetNum("Введите 3-ье число");
CheckTriangle(numberA, numberB, numberC);