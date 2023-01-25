// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
static int DigitSum(int num)
{
  int sum = 0;
  for (int n = num; num > 0; num /= 10)
  {
    sum = num % 10 + sum;
  }
  return sum;
}
int number = new Random().Next(100, 10000);
System.Console.WriteLine($"{number} -> {DigitSum(number)}");