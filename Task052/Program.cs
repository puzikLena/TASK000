﻿// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ArithmeticMean(int[,] matrix)

{
    double[] arithmeticsMean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int columnSum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            columnSum += matrix[j, i];
        }
        arithmeticsMean[i] = columnSum / (double)matrix.GetLength(0);
        arithmeticsMean[i] = Math.Round(arithmeticsMean[i], 1);
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arithmeticsMean.Length; i++)
    {
        Console.Write(arithmeticsMean[i] + "; ");
    }
}

int[,] array = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array);
ArithmeticMean(array);