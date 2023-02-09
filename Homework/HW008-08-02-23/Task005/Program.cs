/* Задача 62: Заполните спирально массив 4 на 4. */

int[,] spiral = CreateSpiral(4, 4);
PrintSpiral(spiral);

int[,] CreateSpiral(int m, int n)
{
  int[,] matr = new int[m, n];
  int length = matr.GetLength(0);
  int num = 1;

  for (int i = 0; i < length; i++)
  {
    matr[0, i] = num; num++;
  }

  for (int i = 1; i < length; i++)
  {
    matr[i, 3] = num; num++;
  }

  num = 10;
  for (int i = 0; i < length - 1; i++)
  {
    matr[3, i] = num; num--;
  }

  num = 12;
  for (int i = 1; i < length - 1; i++)
  {
    matr[i, 0] = num; num--;
  }

  num = 13;
  for (int i = 1; i < length - 1; i++)
  {
    matr[1, i] = num; num++;
  }

  num = 16;
  for (int i = 1; i < length - 1; i++)
  {
    matr[2, i] = num; num--;
  }
  return matr;
}


void PrintSpiral(int[,] arr)
{
  for (int k = 0; k < arr.GetLength(0); k++)
  {
    for (int l = 0; l < arr.GetLength(1); l++)
    {
      if(arr[k, l] < 10) Console.Write($"{arr[k, l]}  ");
      else Console.Write($"{arr[k, l]} ");
    }
    Console.WriteLine();
  }
}