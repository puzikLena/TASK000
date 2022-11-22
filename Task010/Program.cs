// Задача 10: Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num) 
{
    return num % 100 / 10; 
}

int secondDigit = SecondDigit(number);
Console.WriteLine(secondDigit);