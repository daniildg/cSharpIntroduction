int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
  while (num / 1000 != 0)
  {
    num = num / 10;
  }
  System.Console.WriteLine(num % 10);
}
else
{
  System.Console.WriteLine("третьей цифры нет");
}