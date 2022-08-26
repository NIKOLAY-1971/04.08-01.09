// 51. Найдите сумму элементов двухмерного массива, находящихся на главной диагонали.

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
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, "); // 3 - размер вывода числа
            // else Console.Write($"{matrix[i, j],3}");
            Console.Write(j < matrix.GetLength(1) - 1
            ? $"{matrix[i, j],3}, " : $"{matrix[i, j],3}");

        }
        Console.WriteLine("]");
    }
    Console.WriteLine("");
}
int SumArrayElemMainDiagonal(int[,] matrix) // сумма элементов двухмерного массива, 
// находящихся на главной диагонали
{
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) summa += matrix[i, j];
        }
    }
    return summa;
}


int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
int result = SumArrayElemMainDiagonal(array2D);
Console.WriteLine(result);