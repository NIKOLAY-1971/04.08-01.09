// Напишите программу, котрая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет

Console.WriteLine("Введите первое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2) Console.Write($"Первое число {num1} является квадратом второго числа {num2}");
else Console.Write($"Первое число {num1} не является квадратом второго числа {num2}");