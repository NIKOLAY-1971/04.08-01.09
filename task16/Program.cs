// 16. Напишите программу, которая  принимает на вход два числа и
// проверяет, является ли одно число, квадратом другого

Console.WriteLine("Введите 1-е число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == num1 * num1  || num1 == num2 * num2) Console.WriteLine($"Одно из чисел {num1} или {num2} является квадратом другого");
else Console.WriteLine($"Ни одно из чисел {num1} или {num2} не является квадратом другого");
