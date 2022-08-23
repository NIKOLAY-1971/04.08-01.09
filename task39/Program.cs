// 39. Напишите программу, которая перевернет одномерный массив 

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
//  0 1 2 3 4
// [1 2 3 4 5]
// [5 4 3 2 1]
// void ReversArray(int[] array) //Метод1 переворот массива
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;
//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;
//         index1++;
//         index2--;
//     }
// }

void ReversArray1(int[] array) //Метод2 переворот массива
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int obj = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = obj;
    }
}

int[] arr = CreateArrayRndInt(6, 1, 9);
PrintArray(arr);
// ReversArray(arr);
// PrintArray(arr);
ReversArray1(arr);
PrintArray(arr);