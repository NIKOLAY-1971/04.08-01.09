// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int count = 0;
while (n > 0)
{
    n = n / 10;
    count++;
}
if (count < 5 || count > 5) Console.WriteLine($"Введено не корректное число, {count} знака(ов)");
else
{
    if (num / 10000 == num % 10)
    {
        if (num / 1000 % 10 == num / 10 % 10) Console.WriteLine("число является палиндромом");
        else Console.WriteLine("число не является палиндромом");
    }
    else Console.WriteLine("число не является палиндромом");
}