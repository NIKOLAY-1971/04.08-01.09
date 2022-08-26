// 48. Задайте двумерный массив, каждый элемент массива находится по формуле Аmn=m+n. 
// Вывести массив на экран

int[,] CreateMatrixRndInt(int row, int col) // Метод создания массива
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, "); // 3 - размер вывода числа
            // else Console.Write($"{matrix[i, j],3}");
            Console.Write(j < matrix.GetLength(1) - 1 
            ? $"{matrix[i, j],3}, " : $"{matrix[i, j],3}");

        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);