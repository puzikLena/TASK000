// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int result = num1;
    for (int i = 0; i < num2 - 1; i++)
    {
        result = result * num1;
    }
    return result;
}
if (number2 > 0)
{
    int exponentiation = Exponentiation(number1, number2);
    Console.WriteLine(exponentiation);
}
else Console.WriteLine("Введите корректное число! ");


