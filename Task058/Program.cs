// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4   (2 * 3) + (4 * 3)  (2 * 4) + (4 * 3)
// 3 2 | 3 3   (3 * 3) + (2 * 3)  (3 * 4) + (2 * 3)
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],3},");
        }
        Console.WriteLine("|");
    }
}

int[,] ProductOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    int[,] resultMatrix = { { 0, 0 }, { 0, 0 } };
    if (columns1 != rows2)
    {
        Console.WriteLine("Матрицы перемножить нельзя");
    }
    else
    {
        int temp = 0;
        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                temp = 0;
                for (int k = 0; k < columns1; k++)
                {
                    temp += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = temp;
            }
        }

        return result;
    }
    return resultMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 10);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] result = ProductOfMatrix(matrix1, matrix2);
PrintMatrix(result);