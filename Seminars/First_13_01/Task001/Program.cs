// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Enter First Number -> ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second Number -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;

if(number1 == square)
{
  System.Console.WriteLine("True");
}
else
{
  System.Console.WriteLine("False");
}