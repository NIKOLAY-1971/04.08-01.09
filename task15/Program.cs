﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 7)
{
    if (num == 6 || num == 7) Console.WriteLine($"{num} день является выходным");
    else Console.WriteLine($"{num} день не является выходным");
}
else Console.WriteLine("Введено число, которое не может являться днем недели");