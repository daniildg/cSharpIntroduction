/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int[,] matrix = CreateRectangularMatrix(5);
PrintMatrix(matrix);
Console.WriteLine();
int position = IndexOfSmallestSum(matrix);
Console.WriteLine($"строка с наименьшей суммой элементов -> {position}");

int IndexOfSmallestSum(int[,] matr)
{
  int[] sums = GetSumsArray(matr);
  int pos = 0;
  for(int i = 0; i < sums.Length; i++)
  {
    if(sums[pos] > sums[i]) pos = i;
  }
  return pos + 1;
}

int[] GetSumsArray(int[,] matr)
{
  int[] sumsArray = new int[matr.GetLength(0)];
  int row = 0;
  for(int i = 0; i < sumsArray.Length; i++)
  {
    sumsArray[i] = FindSumOfRow(matr, row);
    row++;
  }
  return sumsArray;
}

int FindSumOfRow(int[,] matr, int row)
{
  int[] rowArray = new int[matr.GetLength(1)];
  for(int i = 0; i < matr.GetLength(1); i++)
  {
    rowArray[i] = matr[row, i];
  }
  int sum = 0;
  for(int j = 0; j < rowArray.Length; j++)
  {
    sum += rowArray[j];
  }
  return sum;
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

int[,] CreateRectangularMatrix(int m)
{
  int[,] matr = new int[m, m + 1];
  for (int k = 0; k < matr.GetLength(0); k++)
  {
    for (int l = 0; l < matr.GetLength(1); l++)
    {
      matr[k, l] = new Random().Next(1, 10);
    }
  }
  return matr;
}