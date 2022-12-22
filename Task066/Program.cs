// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalElem(int num1, int num2, int currentNum, int sum)
{
    if (currentNum == num2) 
    {
        return sum;
    }
    sum += currentNum + 1;
    return SumNaturalElem(num1, num2, currentNum + 1, sum);
}

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Введите натуральные числа!");
return;
}

int result = SumNaturalElem(m, n, m, m);
Console.WriteLine(result);