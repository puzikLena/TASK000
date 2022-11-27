// Задача 29: Напишите программу, которая 
// 1.задаёт массив из 8 элементов и 
// 2.выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
FillArray(array);
PrintArray(array);