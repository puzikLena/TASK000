// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double d = Convert.ToDouble(Console.ReadLine());

void IntersectionPoint()
{
    double x = (c - a) / (b - d);
    double y = (b * c - d * a) / (b - d);
    Console.Write($"({Math.Round(x, 1)}; {Math.Round(y, 1)})");
}

IntersectionPoint();
