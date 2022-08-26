// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
void ShowArrayElement(int[,] matrix, int numberi, int numberj) // Метод вывода существующего элемента массива
{
    if (numberi <= matrix.GetLength(0) && numberj <= matrix.GetLength(1))
        Console.WriteLine($"Значение элемента матрицы в ({numberi},{numberj}) равно  {matrix[numberi - 1, numberj - 1]}");
    else Console.WriteLine("такого элемента в массиве нет");
}

Console.WriteLine("Введите номер строки массива:");
int numi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца массива:");
int numj = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
ShowArrayElement(array2D, numi, numj);