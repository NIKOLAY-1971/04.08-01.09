// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] CompositionMatrix(int[,] matrix2D, int[,] matrix2D1) // Метод перемножения матриц
{
    int[,] compositionMatrix = new int[matrix2D.GetLength(0), matrix2D1.GetLength(1)];
    int composition = 1;
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D1.GetLength(1); j++)
        {
            int summa = 0;
            for (int k = 0; k < matrix2D.GetLength(1); k++)
            {
                composition = matrix2D[i, k] * matrix2D1[k, j];
                summa  += composition;
            }
            compositionMatrix[i, j] = summa;
        }
    }
    Console.WriteLine("Результат умножения матриц:");
    return compositionMatrix;
    
}


int[,] array2D = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array2D);
int[,] array2D1 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array2D1);
int[,] composMatrix = CompositionMatrix(array2D, array2D1);
PrintMatrix(composMatrix);