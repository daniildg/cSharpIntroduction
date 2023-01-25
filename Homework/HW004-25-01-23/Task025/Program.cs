// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
int numberA = new Random().Next(1,11);
int numberB = new Random().Next(1,6);

static int Exponent(int numA, int numB)
{
  int result = 1;
  for(int ind = 0; ind < numB; ind++)
  {
    result = result * numA;
  }
  return result;
}
System.Console.WriteLine($"{numberA} ^ {numberB} -> {Exponent(numberA, numberB)}");