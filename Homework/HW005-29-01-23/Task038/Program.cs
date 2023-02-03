//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] array = GetRandomArray(new Random().Next(1,15));
foreach (int num in array)
{
  Console.Write(num + " ");
}
Console.WriteLine();
Array.Sort(array);
int diff = array[array.Length -1] - array[0];
Console.WriteLine($"{array[array.Length -1]} - {array[0]} = {diff}");

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(0, 101);
  }
  return result;
}

// int Max(int[] array)
// {
//     int result = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > result) result = array[i];
//     }
//     return result;
// }

// int Min(int[] array)
// {
//     int result = array[0];
//     for (int ind = 1; ind < array.Length; ind++)
//     {
//         if (array[ind] < result) result = array[ind];
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     foreach (int item in arr)
//     {
//         Console.Write(item + " ");
//     }
//     Console.WriteLine();
// }