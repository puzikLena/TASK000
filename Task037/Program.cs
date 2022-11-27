// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size, int min, int max)
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
int AmountOfDigigts(int[] array)
{
    int amount = 0;
    if (array.Length % 2 == 0) amount = array.Length / 2;
    else amount = (array.Length / 2) + 1;
    return amount;
}
int[] Calculation(int[] array, int amount)
{
    int[] emptyMassive = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        emptyMassive[i] += array[i] * array[array.Length - 1 - i];
    }
    return emptyMassive;
}

int[] massive = (CreateArray(6, 1, 11));
PrintArray(massive);
PrintArray(Calculation(massive, AmountOfDigigts(massive)));


//Не закончена!!!