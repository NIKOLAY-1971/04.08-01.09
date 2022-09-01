// 

// int[] a =  {1,6,6,4,5};
// for (int i = 0; i < a.Length; i++)
// {
//     Console.WriteLine(a[i]);
// }
// int imax = 0;
// for (int k = 0; k < a.Length; k++)
// {
//   int max = a[k];

// for (int i = k; i < a.Length; i++)
// {
//     if (max<=a[i])
//     {
//         max = a[i];
//         imax = i;
//     }
// }
// max = a[k];
// a[k] = a[imax];
// a[imax] = max;


// for (int i = 0; i < a.Length; i++)
// {
//     Console.Write(a[i]);
// }
// Console.WriteLine("");
// }

// Random rnd = new Random();
// int[] a = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     a[i] = rnd.Next(1, 9 + 1);
//     Console.WriteLine(a[i]);
// }

// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine(a[i]);
// }

// void CreateMatrixRndInt(int row, int min, int max) // Метод создания массива
// {
//     Random rnd = new Random();
//     int[] a = new int[row];
//     a[0] = rnd.Next(min, max);
//     Console.WriteLine(a[0]);
//     for (int i = 1; i < a.Length; i++)
//     {
//     link:
//         a[i] = rnd.Next(min, max);

//         for (int t = 0; t < i; t++)
//         {
//             if (a[t] == a[i]) goto link;
//         }
//         Console.WriteLine(a[i]);
//     }
// }
// CreateMatrixRndInt(5, 10, 16);

// int[,,] matrix = new int[2, 2, 2];
//     Random rnd = new Random();
//     matrix[0,0,0] = rnd.Next(3, 6);
//     Console.WriteLine(matrix[0,0,0]);

void CreateMatrixRndInt(int row, int col, int dep, int min, int max) // Метод создания массива
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); i++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                matrix[i, j, d] = rnd.Next(min, max);
                Console.WriteLine($"{matrix[i, j, d]},({i},{j},{d})");
               
            }
        }
    }
    
}




void PrintMatrix(int[,,] matrix) // Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i, j, k]},({i},{j},{k})");
            }
        }
    }
    Console.WriteLine("");
}
CreateMatrixRndInt(2, 2, 2, 10, 100);
// PrintMatrix(array);