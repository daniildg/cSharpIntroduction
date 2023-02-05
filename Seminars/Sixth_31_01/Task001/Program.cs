/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] arr = GetRandomArray(new Random().Next(1,25));
PrintArray(arr);
Console.WriteLine();
PrintArray(ReverseArray(arr));

int[] ReverseArray(int[] array)
{
  int length = array.Length;
  int[] res = new int[length];

  for(int i = 0; i < length; i++)
  {
    res[i] = array[length - 1 -i];
  }
  return res;
}

void PrintArray(int[] arr)
{
  foreach(int item in arr)
  {
    Console.Write(item + " ");
  }
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