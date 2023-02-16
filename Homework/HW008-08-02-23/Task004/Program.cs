/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента. */

void Write3DArray(int[,,] cube)
{
  for (int i = 0; i < cube.GetLength(0); i++)
  {
    for (int j = 0; j < cube.GetLength(1); j++)
    {
      for (int k = 0; k < cube.GetLength(2); k++)
      {
        Console.Write($"{cube[i, j, k]} -> ({i}, {j}, {k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] Create3DArray(int a, int b, int c)
{
  int[,,] cubeArray = new int[a, b, c];
  for (int i = 0; i < cubeArray.GetLength(0); i++)
  {
    for (int j = 0; j < cubeArray.GetLength(1); j++)
    {
      for (int k = 0; k < cubeArray.GetLength(2); k++)
      {
        int num = 0;
        while(IsContained(cubeArray, num))
        {
          num = new Random().Next(10,100);
        }
        cubeArray[i, j, k] = num;    
      }        
    }
  }
  return cubeArray;
}

bool IsContained(int[,,] cube, int el)
{
  for (int i = 0; i < cube.GetLength(0); i++)
  {
    for (int j = 0; j < cube.GetLength(1); j++)
    {
      for (int k = 0; k < cube.GetLength(2); k++)
      {
        if (el == cube[i, j, k]) return true;
      }
    }
  }
  return false;
}
int[,,] array = Create3DArray(5, 3, 5);
Write3DArray(array);