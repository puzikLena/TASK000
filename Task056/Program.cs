// Задача 56: 
// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int GetRowIndexWithMinimalSum(int[,] matrix)
{
    int indexOfRow = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRow += matrix[i, j];
        }
        if (sum == 0)
        {
            sum = sumOfRow;
        }
        else
        {
            if (sumOfRow < sum)
            {
                sum = sumOfRow;
                indexOfRow = i;
            }
        }
    }
    return indexOfRow + 1;
}

int[,] matrix = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(matrix);
int index = GetRowIndexWithMinimalSum(matrix);
Console.WriteLine($"Номер строки с минимальной суммой: {index}");