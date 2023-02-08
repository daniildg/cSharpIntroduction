/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/

int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
ChangeMatrix(matrix);
PrintMatrix(matrix);

void ChangeMatrix(int[,] arr)
{
  for(int i = 0; i < arr.GetLength(1); i++)
  {
    int temp = arr[0, i];
    arr[0, i] = arr[arr.GetLength(0) - 1, i];
    arr[arr.GetLength(0) - 1, i] = temp;
  }
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