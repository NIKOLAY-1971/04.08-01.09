// 63. Задайте значение N. Напишите программу, 
// кторая выведет все натуральные числа от 1 до N.

System.Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
if (num == 0) return;
NaturalNumber(num - 1);
Console.Write($"{num} ");
}
NaturalNumber(number);