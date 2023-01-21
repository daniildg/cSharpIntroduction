//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

System.Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());
int initial_num = num;
int result = 0;

while(num > 0)
{
  result = (result * 10) + num % 10;
  num = num / 10;
}
if(result == initial_num)
{
  System.Console.WriteLine($"{initial_num} -> да");
}
else
{
  System.Console.WriteLine($"{initial_num} -> нет");
}