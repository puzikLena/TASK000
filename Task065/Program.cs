// Задача 65: 
// Задайте значения M и N. 
// Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbersMinToMax(int num1, int num2)
{
    if (num1 >= num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersMinToMax(num1 - 1, num2);
    }
}

void NaturalNumbersAscending(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write($"{num1} ");
         NaturalNumbersAscending(num1 + 1, num2);
    }
}
NaturalNumbersMinToMax(m, n);
NaturalNumbersAscending(m, n);