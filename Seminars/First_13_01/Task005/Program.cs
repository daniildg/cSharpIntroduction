// Необходимо вывести на экран таблицу умножения на 3.

int num = 0;
int num2 = 1;
int multiplier = 3;
while (num2 < 11)
{
  num = num + multiplier;
  Console.WriteLine(multiplier + " * " + num2 + " = " + multiplier * num2);
  num2++;
}