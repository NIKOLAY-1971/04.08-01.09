// Напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num12 = num / 10;
int num2 = num12 % 10;
Console.WriteLine($"Вторая цифра числа {num} -> {num2}");