// Задача 67: Напишите программу, 
// которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
 // int Factorial(int n)
// {
// if(n == 1) return 1;
// else return n * Factorial(n-1);
// }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
  if(num == 0) return 0;
  return num % 10 + SumNumbers(num / 10);
}

int result = SumNumbers(number);
Console.WriteLine(result);

