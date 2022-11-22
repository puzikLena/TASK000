//12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
//кратным второму. Если число 1 не кратно числу 2, то
//программа выводит остаток от деления.
//34,5 -> не кратно, остаток 4
//16,4 -> кратно

Console.WriteLine("Введите 2 числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int number1, int number2)
{
    return number1 % number2;
}

int res = Multiplicity(num1, num2);
if (res == 0)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine($"Не кратно, остаток {res}");

