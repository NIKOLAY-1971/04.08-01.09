// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int ma, int na)
{
    if (ma == 0) return na + 1;
    if (ma > 0 && na == 0) return AckermanFunction(ma - 1, 1);
    else return AckermanFunction(ma - 1, AckermanFunction(ma, na - 1));
}

Console.WriteLine("Введите 1-й аргумент m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-й аргумент n:");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermanFunction(m, n);
Console.WriteLine($"Результат вычисления функции Аккерамана для аргументов ({m},{n}) = {result}");