// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string CoordinateRangee(int quar)
{
    if (quar == 1) return "X>0, Y>0";
    if (quar == 2) return "X<0, Y>0";
    if (quar == 3) return "X<0, Y<0";
    if (quar == 4) return "X>0, Y<0";
    return "Введено неверное число (ввести от 1 до 4)";
}
string result = CoordinateRangee(quarter);
Console.WriteLine(result);