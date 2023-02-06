/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = CreateMatrix(new Random().Next(2, 6), new Random().Next(2, 5));
PrintMatrix(array);
System.Console.WriteLine();
AverageSum(array);

void AverageSum(int[,] arr)
{
  for(int n = 0; n < arr.GetLength(1); n++)
  {
    float sum = 0;
    for(int m = 0; m < arr.GetLength(0); m++)
    {
      sum += arr[m, n];
    }
    System.Console.WriteLine($"{sum / arr.GetLength(0)}");
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