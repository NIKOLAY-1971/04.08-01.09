// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            ? $"{matrix[i, j],3}, " : $"{matrix[i, j],3}");

        }
        Console.WriteLine("]");
    }
    Console.WriteLine("");
}
void ArithmeticMeanColumnElements(int[,] matrix) // Метод определения и вывода среднеарифметического значения 
// элементов столбца
{
    double[] arithmeticMean = new double[matrix.GetLength(1)];
    Console.WriteLine("Среднеарифметическое значение элементов каждого столбца:");
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean[j] += matrix[i, j];
        }
        arithmeticMean[j] = arithmeticMean[j] / matrix.GetLength(1);
        Console.Write(j < arithmeticMean.Length - 1 
        ? $"{Math.Round(arithmeticMean[j], 1)}; " : Math.Round(arithmeticMean[j], 1));
    }
    Console.Write("]");
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
ArithmeticMeanColumnElements(array2D);