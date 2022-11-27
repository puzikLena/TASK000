// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2.Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int EvenElem(int[] array)
{
    int evenElem = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) evenElem++;
    return evenElem;
}
int[] arr = CreateArrayRndInt(6, 100, 999);
PrintArray(arr);
int evenElem = EvenElem(arr);
Console.WriteLine($"Количество чётных чисел в массиве = {evenElem}");

