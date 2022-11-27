﻿// Задача 28: Напишите программу, которая
// 1.принимает на вход число N и 
// 2.выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

if (number > 0)
{
    int facrotial = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {facrotial}");
}
else Console.WriteLine("Требуется ввести натуральное число");


