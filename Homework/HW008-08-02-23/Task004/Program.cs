/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента. */

int[,,] array = Create3DArray(3, 3, 3);
Write3DArray(array);

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
        int cubeLength = cubeArray.GetLength(0)
                      * cubeArray.GetLength(1) * cubeArray.GetLength(2);
        int num = new Random().Next(10, 100);

        if (IsNotContained(cubeArray, num) == true) cubeArray[i, j, k] = num;
        else
          for (int ind = 0; ind < cubeLength; ind++)
          {
            num = new Random().Next(10, 100);
            if (IsNotContained(cubeArray, num) == true) break;
          }
        cubeArray[i, j, k] = num;
      }
    }
  }
  return cubeArray;
}

bool IsNotContained(int[,,] cube, int el)
{
  for (int i = 0; i < cube.GetLength(0); i++)
  {
    for (int j = 0; j < cube.GetLength(1); j++)
    {
      for (int k = 0; k < cube.GetLength(2); k++)
      {
        if (el == cube[i, j, k]) return false;
      }
    }
  }
  return true;
}