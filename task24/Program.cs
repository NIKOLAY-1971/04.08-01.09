// 24. Наипишите программу, которая принимает на вход число (А) и
// выдает сумму чисел от 1 до А

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= num; i++)
// {
//     sum += i; //sum = sum + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");