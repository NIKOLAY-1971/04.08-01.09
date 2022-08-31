// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // Метод создания массива
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix) // Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1
            ? $"{matrix[i, j],3} " : $"{matrix[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
    Console.WriteLine("");
}
void RowMinimumSumElements(int[,] matrix) // Метод поиска минимальной суммы элементов строки
{
    int[] arraySum = new int[matrix.GetLength(0)]; // Массив сумм элементов строки
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
        }
        arraySum[i] = summa;
        Console.WriteLine($"Сумма элементов {i + 1} строки равна {arraySum[i]}");
    }
    Console.WriteLine("");
    int min = arraySum[0];
    int row = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        if (min > arraySum[i])
        {
            min = arraySum[i];
            row = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {row + 1} строке");
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
RowMinimumSumElements(array2D);