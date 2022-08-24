// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int SumNumGreaterZero(int numbers)
{
    int summa = 0;
    int num = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите {i + 1} проверяемое число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) summa++;
    }
    return summa;
}
Console.WriteLine("Введите необходимое количество для проверки чисел:");
int m = Convert.ToInt32(Console.ReadLine());
int result = SumNumGreaterZero(m);
Console.WriteLine($"Количество чисел больше нуля = {result}");