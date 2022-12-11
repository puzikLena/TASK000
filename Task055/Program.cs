// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

int[,] ReplaceRowsToColumns(int[,] arr)
{
    int[,] rowsToColumns = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowsToColumns[i, j] = arr[j, i];
        }

    }
    return rowsToColumns;


}

int[,] array = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    int[,] matrix = ReplaceRowsToColumns(array);
    Console.WriteLine();
    PrintMatrix(matrix);
}

else { Console.WriteLine("Не квадрат"); }
