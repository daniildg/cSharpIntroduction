/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента. */

int[,,] cubeArray = Create3DArray(3, 3, 3);
Write3DArray(cubeArray);

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
  int num = 10;
  for (int i = 0; i < cubeArray.GetLength(0); i++)
  {
    for (int j = 0; j < cubeArray.GetLength(1); j++)
    {
      for (int k = 0; k < cubeArray.GetLength(2); k++)
      {
        cubeArray[i, j, k] = num;
        num++;
      }
    }
  }
  return cubeArray;
}