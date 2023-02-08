/* Задача 55: Задайте двумерный массив.
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

int[,] doubleArray = CreateMatrix(4, 4);
PrintMatrix(doubleArray);
System.Console.WriteLine();
GetResult(doubleArray);

void GetResult(int[,] arr)
{
  if(arr.GetLength(0) == arr.GetLength(1)) PrintMatrix(StringToColumns(doubleArray));
  else System.Console.WriteLine("действие не может быть выполнено");
}

int[,] StringToColumns(int[,] matr)
{
  int[,] arr = new int[matr.GetLength(0), matr.GetLength(1)];
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      arr[i, j] = matr[j, i];
    }
  }
  return arr;
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

int[,] CreateMatrix(int m, int n)
{
  int[,] matr = new int[m, n];
  for (int k = 0; k < matr.GetLength(0); k++)
  {
    for (int l = 0; l < matr.GetLength(1); l++)
    {
      matr[k, l] = new Random().Next(1, 11);
    }
  }
  return matr;
}