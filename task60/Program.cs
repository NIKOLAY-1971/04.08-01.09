// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int row, int col, int dep, int min, int max) // Метод создания массива
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();
    int[] a = new int[matrix.Length];
    a[0] = rnd.Next(min, max);
    int k = 0;
    for (int i = 1; i < a.Length; i++) // Проверка совпадения числа, получение неповторяющихся чисел
    {
    link:
        a[i] = rnd.Next(min, max);

        for (int t = 0; t < i; t++)
        {
            if (a[t] == a[i]) goto link;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                matrix[i, j, d] = a[k];
                k++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix) // Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                Console.WriteLine($"{matrix[i, j, d]},({i},{j},{d})");
            }
        }
    }
    Console.WriteLine("");
}

int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintMatrix(array3D);
