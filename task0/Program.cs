﻿// Напишите программу, которая на вход
// принимает число и выдает его квадрат (число
//умноженное на смао себя).
//Например:
//4->16
//3->9
//7->49

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");


// Напишите программу, котрая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет