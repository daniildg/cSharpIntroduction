/*Задача 40: Напишите программу, 
которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

bool CompareNum(int num1, int num2, int num3)
{
  return(((num1 + num2) > num3) 
        && ((num1 + num3) > num2) 
        && ((num2 + num3) > num1));
}
Console.WriteLine(CompareNum(2, 2, 2));