//Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

System.Console.Write("Enter Number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
  System.Console.WriteLine("yes");
}
else
{
  System.Console.WriteLine("no");
}