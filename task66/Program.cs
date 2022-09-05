// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SummNaturalNumber(int numM, int numN)
{
    if (numM > numN)
    {
        int t = numM;
        numM = numN;
        numN = t;
    }
    {
        if (numM == numN) return numN;
        return numM + SummNaturalNumber(numM + 1, numN);
    }
    // else
    // {
    //     if (numM == numN) return numM;
    //     return numN + SummNaturalNumber(numN + 1, numM);
    // }
}

Console.WriteLine("Введите первое целое положительное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int n = Convert.ToInt32(Console.ReadLine());
SummNaturalNumber(m, n);
Console.Write($"Сумма чисел от {m} до {n} равна {SummNaturalNumber(m, n)}");