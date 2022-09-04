// 69. Напишите программу, которая на вход принимает два числа А и В, 
// и возводит число А в целую степень В с помощью рекурсии.

Console.WriteLine("Введите основание степени числа:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степенm числа:");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    
if (num2 == 0) return 1;
return num1 * Degree(num1, num2 -1);

}
int result = Degree(a, b);
Console.WriteLine(result);