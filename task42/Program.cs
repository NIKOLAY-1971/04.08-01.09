// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());

int res = 0;
int mult = 1;
while (x > 0)
{
    res += x % 2 * mult;
    x = x / 2;
    mult *=10;
}
Console.WriteLine(res);
