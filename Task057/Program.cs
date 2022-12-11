// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray (int[,] matrix)
{
    int k = 0;
    int[] array = new int [matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void FindClone (int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] == num)
        count++;
        else
        {
            Console.WriteLine($"{num} {count}");
            num = arr[i];
            count = 1;
        } 
    }
    Console.WriteLine($"{num} {count}");
}
int [,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int [] newArray =  MatrixToArray(array2D);
Array.Sort(newArray);
PrintArray(newArray);
FindClone(newArray);
PrintArray(newArray);




// // еще один
// int[] ReverceMatrixToArray(int[,] matrix)
// {
//     int y = 0;
//     int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[y] = matrix[i, j];
//             y++;
//         }
//     }
//     return arr;
// }


// int[,] array2D = CreateMatrixRndInt(2, 3, 0, 10);
// PrintMatrix(array2D);
// Console.WriteLine(" ");
// int[] array = ReverceMatrixToArray(array2D);
// PrintArray(array);
// Array.Sort(array);
// PrintArray(array);

// void PrintResult(int [] arr)
// {
// int count = 1;
// int num = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (array[i] == num) count ++;
//     else 
//     {
//         Console.WriteLine($"{num} = {count}");
//         num = arr[i];
//         count = 1;
//     }
// }
// Console.WriteLine($"{num} = {count}");
// }
// PrintResult(array);
