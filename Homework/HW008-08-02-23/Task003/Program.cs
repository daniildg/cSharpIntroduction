/* Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц. */

int[,] matrix1 = CreateMatrix(3, 3);
int[,] matrix2 = CreateMatrix(3, 3);
PrintMatrix(matrix1);
Console.WriteLine('*');
PrintMatrix(matrix2);
System.Console.WriteLine('=');
PrintMatrix(MultiplyArray(matrix1, matrix2));

int[,] MultiplyArray(int[,] mtrx1, int[,] mtrx2)
{
  int row1 = mtrx1.GetLength(0);
  int col1 = mtrx1.GetLength(1);
  int col2 = mtrx2.GetLength(1);

  int[,] result = new int[row1, col2];
  for (int i = 0; i < row1; i++)
  {
    for (int j = 0; j < col2; j++)
    {
      int temp = 0;
      for (int n = 0; n < col1; n++)
      {
        temp += mtrx1[i, n] * mtrx2[n, j];
      }
      result[i, j] = temp;
    }
  }
  return result;
}

void PrintMatrix(int[,] mtrx)
{
  for (int i = 0; i < mtrx.GetLength(0); i++)
  {
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
      Console.Write($"{mtrx[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] CreateMatrix(int a, int b)
{
  int[,] matr = new int[a, b];
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
  return matr;
}