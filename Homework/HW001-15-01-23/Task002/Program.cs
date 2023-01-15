// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter First Number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(num1, num2);
int min = Math.Min(num1, num2);

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);