//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Enter Number ");
int weekDay = Convert.ToInt32(Console.ReadLine());
switch(weekDay)
{
  case 6 or 7:
  Console.WriteLine($"{weekDay} -> Yes");
  break;
  default:
  Console.WriteLine($"{weekDay} -> No");
  break;
}