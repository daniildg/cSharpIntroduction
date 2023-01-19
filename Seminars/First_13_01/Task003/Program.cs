//Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

System.Console.Write("Enter Number -> ");
int initial_num = Convert.ToInt32(Console.ReadLine());
int num = initial_num * -1;
System.Console.Write($"{initial_num} -> ");
while(num <= initial_num - 1)
{
  System.Console.Write(num + ",");
  num++;
}
System.Console.WriteLine(num + ".");