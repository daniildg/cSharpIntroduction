//Программа, которая по заданному номеру четверти оси координат (x,y) 
// и показывает диапозон возможных координат точек в этой четверти.

int num = new Random().Next(1,5);
System.Console.WriteLine(num);

if(num == 1)
{
  System.Console.WriteLine("x:= (0; +inf), y:= (0; +inf)");
}
else if(num == 2)
{
  System.Console.WriteLine("x:= (0; -inf), y:= (0; +inf)");
}
else if(num == 3)
{
  System.Console.WriteLine("x:= (0; -inf), y:= (0; -inf)");
}
else
{
  System.Console.WriteLine("x:= (0; +inf), y:= (0; -inf)");
}