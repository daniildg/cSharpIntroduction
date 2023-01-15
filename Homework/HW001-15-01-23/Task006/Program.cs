// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter Number");
int num = Convert.ToInt32(Console.ReadLine());

switch(num % 2)
{
  case 0:
    Console.WriteLine("Yes");
    break;
  
  default:
    Console.WriteLine("No");
    break;
}