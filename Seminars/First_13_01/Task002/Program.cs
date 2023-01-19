//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Enter Number -> ");
int num = Convert.ToInt32(Console.ReadLine());
if(num == 1)
{
  System.Console.WriteLine($"{num} -> Понедельник");
}
else if(num == 2)
{
  System.Console.WriteLine($"{num} -> Вторник");
}
else if(num == 3)
{
  System.Console.WriteLine($"{num} -> Среда");
}
else if(num == 4)
{
  System.Console.WriteLine($"{num} -> Четверг");
}
else if(num == 5)
{
  System.Console.WriteLine($"{num} -> Пятница");
}
else if(num == 6)
{
  System.Console.WriteLine($"{num} -> Суббота");
}
else if(num == 7)
{
  System.Console.WriteLine($"{num} -> Воскресенье");
}
else
{
  System.Console.WriteLine($"{num} -> Неизвестное число");
}