/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */

int[,] matrix = CreateMatrix(5, 7);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(BuildSortedMatrix(matrix));

int[,] BuildSortedMatrix(int[,] matr)
{
  int n = 0;
  for(int l = 0; l < matr.GetLength(0); l++)
  {
    int[] sortedRow = SortRowArray(matr, n);
    for(int k = 0; k < matr.GetLength(1); k++)
    {
      matr[l,k] = sortedRow[k];
    }
    n++;
  }
  return matr;
}

int[] SortRowArray(int[,] matr, int row)
{
  int[] rowArray = new int[matr.GetLength(1)];
  for(int i = 0; i < matr.GetLength(1); i++)
  {
    rowArray[i] = matr[row, i];
  }
  Array.Sort(rowArray);
  Array.Reverse(rowArray);
  return rowArray;
}

void PrintMatrix(int[,] matr)
{
  for (int k = 0; k < matr.GetLength(0); k++)
  {
    for (int l = 0; l < matr.GetLength(1); l++)
    {
      Console.Write($"{matr[k, l]} ");
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