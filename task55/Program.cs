// 55. Задайте двумерный массив. Напишите програму,которая заменяет строки на столбцы.
// В случае если это не возможно программа должна вывести сообщение для пользователя.

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
int[,] MatrixTransposition(int[,] matrix) // Метод транспонирования
{
    int[,] matrixT = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrixT.GetLength(0); i++)
    {
        for (int j = 0; j < matrixT.GetLength(1); j++)
        {
            matrixT[i, j] = matrix[j, i];
        }
    }
    return matrixT;
}

int[,] array2D = CreateMatrixRndInt(3, 5, 1, 9);
PrintMatrix(array2D);
int[,] array2DT = MatrixTransposition(array2D);
PrintMatrix(array2DT);
