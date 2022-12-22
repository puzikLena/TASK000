﻿// Задача 68:
//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//   Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int num2 = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num1 != 0 && num2 == 0)
        return AckermanFunction(num1 - 1, 1);
    if (num1 > 0 && num2 > 0)
        return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
    return AckermanFunction(num1, num2);
}

Console.WriteLine($"A({num1},{num2}) = {AckermanFunction(num1, num2)}");