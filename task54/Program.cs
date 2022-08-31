// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        Console.WriteLine("]");
    }
    Console.WriteLine("");
}
void SortingDescendingRowElements(int[,] matrix) //// Метод сортировки по убыванию элементов строки
{
    int im = 0;
    int jm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            int max = matrix[i, k];
            for (int j = k; j < matrix.GetLength(1); j++) // индексы максимального элемента строки
            {
                if (max <= matrix[i, j])
                {
                    max = matrix[i, j];
                    im = i;
                    jm = j;
                }
            }
            max = matrix[i, k];
            matrix[i, k] = matrix[im, jm];
            matrix[im, jm] = max;
        }
    }
    
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
SortingDescendingRowElements(array2D);
PrintMatrix(array2D);