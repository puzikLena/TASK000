//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

bool result = MultiplicityTwoDigits(number, 7, 23);

Console.Write($"{number} -> ");
Console.WriteLine(result ? "Да" : "Нет");

