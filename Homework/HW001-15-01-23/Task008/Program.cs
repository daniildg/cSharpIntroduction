// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Enter Number");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
  Console.Write(i);
  Console.Write(" ");
}