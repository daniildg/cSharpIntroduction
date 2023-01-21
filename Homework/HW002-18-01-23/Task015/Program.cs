//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Enter Number ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if(weekDay == 6 || weekDay == 7) // связка двух условий (выполняется если одно из условий верно)
{
  Console.WriteLine($"{weekDay} -> Yes");
}
else
{
  Console.WriteLine($"{weekDay} -> No");
}