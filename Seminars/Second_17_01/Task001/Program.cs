// Программа, которая выодит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру этого числа.

int num = new Random().Next(10, 100);
System.Console.WriteLine($"{"Your Number Is"} -> {num}");
int firstResult = num / 10;
int secondResult = num % 10;

if(firstResult < secondResult)
{
  System.Console.WriteLine($"{"Largest Number Is"} -> {secondResult}");
}
else
{
  System.Console.WriteLine($"{"Largest Number Is"} -> {firstResult}");
}