//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
int n = new Random().Next(1, 21);
System.Console.WriteLine($"num = {n}");

for (int i = 1; i <= n; i++)
{
  System.Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
}