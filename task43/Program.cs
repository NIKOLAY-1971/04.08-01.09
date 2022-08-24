// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] T(double a1, double c1, double a2, double c2)
{
    double x = Math.Round((c1 - c2) / (a2 - a1), 1);
    double y = a1 * x + c1;
    return new double[] { x, y };
}

Console.WriteLine("Введите коэффициент k1 при переменной х первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент b1 первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 при переменной х второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный коэффициент b2 второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] result = T(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения двух прямых: ({result[0]}; {result[1]})");