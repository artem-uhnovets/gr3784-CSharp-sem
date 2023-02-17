// Напишите программу, которая будет принимать 
// на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
int num1 = new Random().Next(1,10);
Console.WriteLine($"Ваше 1ое случайное число {num1}");

int num2 = new Random().Next(1,10);
Console.WriteLine($"Ваше 2ое случайное число {num2}");

int result = num1%num2;
if (result == 0)
{
    Console.WriteLine($"Число {num1} кратно числу {num2}.");
}
else
{
    Console.WriteLine($"Число {num1} не кратно числу {num2}. Остаток равен {result}");
}

// if (result == 0) Console.WriteLine($"Число {num1} кратно числу {num2}.");
// else Console.WriteLine($"Число {num1} не кратно числу {num2}. Остаток равен {result}");