//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] array = GetRandomArray(10);
foreach (int num in array)
{
  Console.Write(num + " ");
}
Console.WriteLine();
Array.Sort(array);
Console.WriteLine($"{array[9]} - {array[0]} = {array[9] - array[0]}");

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