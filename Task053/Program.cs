﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) //2
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
//             else Console.Write($"{matrix[i, j],4} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// void RepLaceLines(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] = matrix[matrix.GetLength(0) - 1,i];
//         matrix[matrix.GetLength(0) - 1,i] = temp;
//     }
// }

// int[,] array = CreateMatrixRndInt(3, 4, -10, 10);
// PrintMatrix(array);
// Console.WriteLine();
// RepLaceLines(array);
// не работает