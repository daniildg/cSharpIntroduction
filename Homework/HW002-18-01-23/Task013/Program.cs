//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

System.Console.Write("Enter Number ");
int num = Convert.ToInt32(Console.ReadLine());
int initialNumber = num;
if(num > 99)
{
  while (num / 1000 != 0)
  {
    num = num / 10;
  }
  System.Console.WriteLine($"{initialNumber} -> {num % 10}");
}
else
{
  System.Console.WriteLine($"{initialNumber} -> третьей цифры нет");
}