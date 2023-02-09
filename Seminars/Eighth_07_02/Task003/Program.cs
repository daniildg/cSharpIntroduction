/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */

int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = GetArray(matrix);
Array.Sort(array);
WriteVocabulary(array);

void WriteVocabulary(int[] arr)
{
  int element = arr[0];
  int count = 1;
  for(int i = 1; i < arr.Length; i++)
  {
    if(element != array[i])
    {
      Console.WriteLine($"{element} -> {count} раз(а)");
      element = array[i];
      count = 1;
    }
    else count++;
  }
  Console.WriteLine($"{element} -> {count} раз(а)");
}

int[] GetArray(int [,] matr)
{
  int[] result = new int[matr.GetLength(0) * matr.GetLength(1)];
  int index = 0;
  for(int i = 0; i < matr.GetLength(0); i++)
  {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
      result[index] = matr[i, j];
      index++;
    }
  }
  return result;
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