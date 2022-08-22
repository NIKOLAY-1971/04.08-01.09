// 1. Метод: ничего не возвращает и не принимает

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();



// 2 Метод: принимают, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count) // явное указание аргумента - поименнованное
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); // 4 раза выводит слово Текст
// Method21(count: 4, msg: "Новый текст"); // 4 раза выводит слово Новый текст




//3. Метод: что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);


// 4. Метод: что-то принимают и что-то возвращают

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // присваение пустой строки (string result = "";)
    while (i < count)
    {
        result += c;
        i++;
    }
    return result;
}
// string res = Method4(10, "abc"); //выводит  10 раз abc
// Console.WriteLine(res);

// Двойные массивы
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int row = 0; row < 2; row++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[row, columns]}-");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++) //GetLength(0) - количество строк
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // GetLength(1) - количество столбцов
        {
            Console.Write($"{matr[row, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - количество столбцов
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10)]
        }
    }
}

int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);


// Рекурсия

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n* Factorial(n - 1);
}
Console.WriteLine(Factorial(3));