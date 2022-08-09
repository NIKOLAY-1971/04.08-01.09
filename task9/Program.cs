﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапазона 10-99 {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit) Console.WriteLine("цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая часть числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая часть числа {number} -> {secondDigit}");

// string result = firstDigit == secondDigit ? "цифры равны"
// : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"Наибольшая часть числа {number} -> {result}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit; 
}
int result = MaxDigit(number);
string res = result == 0 ? "цифры равны" : result.ToString();
Console.WriteLine($"Наибольшая часть числа {number} -> {res}");
