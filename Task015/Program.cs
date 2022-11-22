// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0)
{
    if (number == 6 || number == 7) 
    {
        Console.WriteLine("Да ");
    }
    else Console.WriteLine("Нет ");
}
else Console.WriteLine("Введите корректное число!");