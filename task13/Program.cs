// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 == 0) Console.WriteLine("третьей цифры нет");
else
{
    int n = num;
    int count = 0;
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
int num3 = (num / Convert.ToInt32(Math.Pow(10, count - 3))) % 10; Console.WriteLine($"третье число {num3}");
}