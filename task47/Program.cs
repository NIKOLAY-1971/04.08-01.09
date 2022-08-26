// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] CreateMatrixRnd(int row, int col, int min, int max) // Метод создания массива
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }

    }
    return matrix;
}
void PrintMatrix(double[,] matrix) // Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1
            ? $"{Math.Round(matrix[i, j], 1),4}, " : $"{Math.Round(matrix[i, j], 1),4}");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRnd(3, 4, -9, 9);
PrintMatrix(array2D);