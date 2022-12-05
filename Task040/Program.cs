// Задача 40: Напишите программу, 
// которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
Console.Write("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < (b + c) && b < (a + c) && c < (a + b);
}

Console.WriteLine(Triangle(num1, num2, num3) ? "Да" : "Нет");