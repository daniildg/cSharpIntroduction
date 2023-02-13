﻿/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumRec(int num)
{
  if(num == 0) return 0;
  else return num % 10 + SumRec(num / 10);
}

Console.WriteLine(SumRec(4637));