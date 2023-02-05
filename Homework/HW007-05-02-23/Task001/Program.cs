/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] matrix = Create2DArray(4, 3);
Show2DArray(ConvertToDouble(matrix));

double[,] Create2DArray(int k, int l)
{
  double[,] matr = new double[k, l];

  for (int m = 0; m < matr.GetLength(0); m++)
  {
    for (int n = 0; n < matr.GetLength(1); n++)
    {
      matr[m, n] = new Random().Next(-25, 26);
    }
  }
  return matr;
}

double[,] ConvertToDouble(double[,] matr)
{
  for (int m = 0; m < matr.GetLength(0); m++)
  {
    for (int n = 0; n < matr.GetLength(1); n++)
    {
      if (matr[m, n] > 10 || matr[m, n] < -10) matr[m, n] /= 10;
    }
  }
  return matr;
}

void Show2DArray(double[,] matr)
{
  for (int m = 0; m < matr.GetLength(0); m++)
  {
    for (int n = 0; n < matr.GetLength(1); n++)
    {
      Console.Write($"{matr[m, n]} ");
    }
    Console.WriteLine();
  }
}