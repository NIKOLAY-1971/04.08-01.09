// 28. Напишите программу, которая прнимает на вход число N и
// выдает произведение чисел от 1 до N

Console.WriteLine("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int composition = 1;
for (int i = 1; i <= n; i++)
{
    composition = composition * i;
}
Console.WriteLine($"Произведение чисел от 1 до {n} равно {composition}");