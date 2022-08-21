//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, double min, double max) // Метод создания массива
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}
void PrintArray(double[] array) // Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

double SumElemOddPositions (double[] array) // Метод подсчета суммы разницу между 
// максимальным и минимальным элементами массива
{
    double xmin = array[0];
    double xmax = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (xmin > array[i]) xmin = array[i];
        if (xmax < array[i]) xmax = array[i];
    }
    double diff = Math.Round(xmax - xmin, 1);
    return diff;
}

double[] arr = CreateArrayRndInt(5, 1, 100);
PrintArray(arr);
Console.WriteLine($"разница между максимальным и манимальным элементами массива равна {SumElemOddPositions(arr)}");