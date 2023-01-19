//Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Enter Number -> ");
int num = Convert.ToInt32(Console.ReadLine());
int lastDigit = num % 10;
System.Console.WriteLine($"{num} -> {lastDigit}");