//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Enter Number -> ");
int num = Convert.ToInt32(Console.ReadLine());
switch(num)
{
  case 1:
  System.Console.WriteLine($"{num} -> Понедельник");
  break;

  case 2:
  System.Console.WriteLine($"{num} -> Вторник");
  break;

  case 3:
  System.Console.WriteLine($"{num} -> Среда");
  break;

  case 4:
  System.Console.WriteLine($"{num} -> Четверг");
  break;

  case 5:
  System.Console.WriteLine($"{num} -> Пятница");
  break;

  case 6:
  System.Console.WriteLine($"{num} -> Суббота");
  break;

  case 7:
  System.Console.WriteLine($"{num} -> Воскресенье");
  break;

  default:
  System.Console.WriteLine($"{num} -> Неизвестное число");
  break;
}