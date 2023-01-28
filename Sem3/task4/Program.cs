// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

void Square(int number)
{
    int index = 1;
    while (index < number)
    {
        Console.Write(index*index + ", ");
        index++;
    }
    Console.Write(index*index);
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// ввод данных от пользователя
int number = GetNum("Введите число ");

// определить таблицу квадратов чисел
Square(number);