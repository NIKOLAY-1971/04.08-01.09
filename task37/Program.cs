// 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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

Console.WriteLine("Введите количество элементов одномерного массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(length, 1, 10);
PrintArray(arr);


int[] ProdPairsNumbers(int[] array) //Произведение крайних пар чисел
{
    int length1 = 0;
    if (array.Length % 2 == 0) length1 = array.Length / 2;
    else length1 = array.Length / 2 + 1;
    int[] array1 = new int[length1];
    for (int i = 0; i < array1.Length; i++)
    {
        if (i == array1.Length - 1 &&  (array1.Length - 1) % 2 == 0) array1[i] = array[length1];
        else array1[i] = array[i] * array[array.Length - i - 1];
        
    }
    return array1;
}
int[] arr1 = ProdPairsNumbers(arr);
PrintArray(arr1);