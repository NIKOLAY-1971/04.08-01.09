// 65. Задайте занчения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

System.Console.WriteLine("Введите первое целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int numM, int numN)
{
    if (numM < numN)
    {
        NaturalNumber(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumber(numM - 1, numN);

    }
    if (numM == numN) Console.Write($"{numM} ");

}
NaturalNumber(numberM, numberN);