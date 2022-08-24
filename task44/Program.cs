// Не используя рекурсию получить числа Фибоначчи (первые два числа - 0 и 1)
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

void Fibanacci(int number)
{
    int num1 = 0;
    int num2 = 1;
    Console.Write($"{num1} {num2} ");
    for (int i = 2; i < n; i++)
    {
        int temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Console.Write(num2 + " ");
    }
}
Fibanacci(n);