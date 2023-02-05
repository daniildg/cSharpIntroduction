/*Задача 45: Напишите программу, 
которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/
int[] array = GetRandomArray(10);
PrintArray(array);
Console.WriteLine();
PrintArray(CopyArray(array));

int[] CopyArray(int[] arr)
{
  int[] result = new int[arr.Length];
  for(int i = 0; i < arr.Length; i++)
  {
    result[i] = arr[i];
  }
  return result;
}

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(-100, 100);
  }
  return result;
}

void PrintArray(int[] arr)
{
  foreach(int item in arr)
  {
    Console.Write(item + " ");
  }
}