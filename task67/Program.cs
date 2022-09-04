// 67. Напишите программу, которая на вход 
// принимает число и возвращает сумму его цифр.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigital(int num)
{
    int sum = num % 10;
    if (num == 0) return sum;
    return sum += SumDigital(num / 10);
}
int result = SumDigital(number);
Console.WriteLine(result);