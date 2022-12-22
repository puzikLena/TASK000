// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int  A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    if (num2 == 1) return num1;
    return num1 * Exponentiation(num1, num2 - 1);
}

int result = Exponentiation(A, B);
Console.WriteLine(result);