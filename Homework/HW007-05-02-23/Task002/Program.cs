/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int m = new Random().Next(0,5);
int n = new Random().Next(0,5);
Console.WriteLine($"Координаты -> {m}, {n}");
var array = CreateMatrix(3, 4);
PrintMatrix(array);
Console.WriteLine($"{GetResult(array, m, n)}");

string GetResult(int[,] arr, int m, int n)
{
  if (m < arr.GetLength(0) && n < arr.GetLength(1)) return $"{arr[m, n]} -> это число есть";
  else return "  -> такого числа нет ";
}

int[,] CreateMatrix(int m, int n)
{
  int[,] matr = new int[m, n];
  for (int k = 0; k < matr.GetLength(0); k++)
  {
    for (int l = 0; l < matr.GetLength(1); l++)
    {
      matr[k, l] = new Random().Next(10, 101);
    }
  }
  return matr;
}

void PrintMatrix(int[,] arr)
{
  for (int k = 0; k < arr.GetLength(0); k++)
  {
    for (int l = 0; l < arr.GetLength(1); l++)
    {
      Console.Write($"{arr[k, l]} ");
    }
    Console.WriteLine();
  }
}
