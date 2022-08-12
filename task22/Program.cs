// 22. Напишите программу, которая принимает на вход число (N) и
// выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите положительное число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Введено не корректное число");
else
{
    for (int i = 1; i <= n; i++)
    {
        int SquareNumber = i * i;
        Console.WriteLine($"{i}  {SquareNumber}");
    }
}