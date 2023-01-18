//Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Enter Number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {(num % 100) / 10}");