// 40. Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины


Console.WriteLine("Введите 1-е число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int x3 = Convert.ToInt32(Console.ReadLine());

bool Ttiangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}
bool result = Ttiangle(x1, x2, x3);
Console.WriteLine(result ? "треугольник со сторонами такой длины существует" : 
"треугольник со сторонами такой длины не существует");