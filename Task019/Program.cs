// Задача 19
// Напишите программу, которая 
// 1.принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindro(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    bool result = firstDigit == (num % 10) && secondDigit == (num % 100 / 10);
    return result;
}

bool IsPalindro = Palindro(number);
if (IsPalindro)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
