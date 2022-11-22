// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 1000)
    {
     num = num / 10;
    }
    return num % 10;
}
if (number < 0) number = -number;
if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
