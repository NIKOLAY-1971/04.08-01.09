// 33. Задайте массив, напишите программу, которая определяет, 
// присутствует ли заданное число в массиве

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

bool FindNumber(int[] array, int num) // Совпадение числа в массиве
{
    bool j = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) j = true;
    }
    return j;
}

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(6, 1, 8);
PrintArray(arr);
bool result = FindNumber(arr, number);
Console.WriteLine(result?"Да":"Нет");