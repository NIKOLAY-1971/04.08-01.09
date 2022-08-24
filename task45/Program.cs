// Напишите програму, которая будет создавать копию данного массива
// с помощью поэлементного копирования

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

int[] CopyArray(int[] array) // Копирование элементов
{
    int[] array1 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array1[i] = array[i];
    }
    return array1;
}

int[] arr = CreateArrayRndInt(10, 1, 10);
PrintArray(arr);
int[] arr1 = CopyArray(arr);
PrintArray(arr1);
