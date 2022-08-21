// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array) // Метод вывода массива
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
int NumArrayElements(int[] array) //Подсчет количества элементов на отрезке
{
int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) quantity++;
}
return quantity;
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

Console.WriteLine($"Количество элементов массива на отрезке [10, 99] равно {NumArrayElements(arr)}");