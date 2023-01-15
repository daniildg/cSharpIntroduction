// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter First Number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Third Number");
int num3 = Convert.ToInt32(Console.ReadLine());

int initialMax = Math.Max(num1, num2);
int finalMax = Math.Max(initialMax, num3);

Console.Write("max = ");
Console.WriteLine(finalMax);