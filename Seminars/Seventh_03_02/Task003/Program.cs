/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/

var arr = Generate2DArray(3, 4);
Print2DArray(arr);
ModifyArray(arr);
Console.WriteLine();
Print2DArray(arr);

void ModifyArray(int[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
      {
        arr[i, j] = (int)Math.Pow(arr[i, j], 2); // convert from double to int
      }
    }
  }
}

int[,] Generate2DArray(int m, int n)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = new Random().Next(2,16);
    }
  }
  return result;
}

void Print2DArray(int[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}