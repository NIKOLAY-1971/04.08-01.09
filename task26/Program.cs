// 26. Напищите программу, которая принимает на вход число и
// выдает количество цифр в числе

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int NumberCharacters = 0;
while (n > 0)
{
    n = n / 10;
    NumberCharacters++;
}
 Console.WriteLine($"Количество цифр в числе {num} равно {NumberCharacters}");