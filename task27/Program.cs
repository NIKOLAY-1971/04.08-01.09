// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int count = 0;
int summa = 0;
while (n > 0)
{
    summa = summa + n % 10;
    n = n / 10;
    count++;
}
Console.WriteLine($"Сумма цифр числа {num} равна {summa}");