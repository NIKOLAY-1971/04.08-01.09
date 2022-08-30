// 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

void CountingIdenticalMatrixElements(int[,] matrix)
{
    int[] array = new int[matrix.Length]; // Перевод двумерного в одномерный массив
    int quantity = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[quantity] = matrix[i, j];
            quantity++;
        }
    }
    Array.Sort(array); // Сортировка  и подсчет количества элементов одномерного массива
    int count = 1;
    int value = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != value)
        {
            Console.WriteLine($"Значение {value} встречается {count} раз");
            value = array[i];
            count = 1;
        }
        else count++;
    }
    Console.WriteLine($"Значение {value} встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array2D);
CountingIdenticalMatrixElements(array2D);