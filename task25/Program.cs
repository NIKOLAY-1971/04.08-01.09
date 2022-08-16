// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два натуральных числа");
Console.WriteLine("Первое число (основание степени): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число (показатель степени): ");
int b = Convert.ToInt32(Console.ReadLine());
int degree = 1;
for (int i = 1; i <= b; i++)
{
  degree = degree * a;  
}
Console.WriteLine($"{a} в степени {b} равно {degree}");