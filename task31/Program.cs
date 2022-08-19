// 31. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max +1);
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
int[] GetSumPolNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
        else sumPol += array[i];
    }
    return new int[] {sumNeg, sumPol}; //sumNeg как 0 объект, sumPol как 1 объект в строке 40 и 41
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumPolNegElem = GetSumPolNegElem(arr);
Console.WriteLine($"Сумма отрицательных чисел = {sumPolNegElem[0]}");
Console.WriteLine($"Сумма положительных чисел = {sumPolNegElem[1]}");