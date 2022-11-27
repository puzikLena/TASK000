// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}  ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxElem(double[] array, int min)
{
    double maxElem = min;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem)
        {
            maxElem = array[i];
        }
    }
    return maxElem;
}

double MinElem(double[] array, int max)
{
    double minElem = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
        }
    }
    return minElem;
}

double[] arr = CreateArrayRndDouble(6, 0, 100);
PrintArray(arr);
double delta = MaxElem(arr, 0) - MinElem(arr, 100);
Console.WriteLine($"Разница между Max и Min = {delta}");