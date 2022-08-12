// 20. Напишите программу, которая принимает на вход координаты двух точек и 
// находит рассотяние между ними в 2D пространстве
// А (3, 6) B(2, 1) ->5,09
// А (7, -5) B(1, -1) ->7,21

Console.WriteLine("Введите координаты двух точек:");
Console.Write("координата X 1-й точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("координата Y 1-й точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("координата X 2-й точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("координата Y 2-й точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    return  Math.Sqrt((xc1 - xc2) * (xc1 - xc2) + (yc1 - yc2) * (yc1 - yc2));
}
double result = Distance(x1, y1, x2, y2);
Console.WriteLine(result);