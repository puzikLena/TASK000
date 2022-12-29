// Написать программу, 
// которая из имеющегося массива строк формирует массив из сторок,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] array = { "hello", "2", "world", ":-)" };

int GetStringsCount(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FilterArray(string[] arr)
{
    int arraySize = GetStringsCount(arr);
    string[] filteredArray = new string[arraySize];

    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            filteredArray[k] = arr[i];
            k++;
        }
    }
    return filteredArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"\"{arr[i]}\"");
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

PrintArray(array);
Console.Write("->");
PrintArray(FilterArray(array));
