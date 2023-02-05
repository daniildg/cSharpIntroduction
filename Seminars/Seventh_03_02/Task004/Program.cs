/*Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
*/

Print2DArray(Generate2DArray(3, 4));



int[,] Generate2DArray(int m, int n)
{
   int[,] result = new int[m, n];
   for(int i = 0; i < result.GetLength(0); i++)
   {
       for(int j = 0; j < result.GetLength(1); j++)
       {
           result[i, j] = new Random().Next(1, 100);
       }
   }
   return result;
}

void Print2DArray(int[,] array)
{  
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           Console.Write($"{arr[i, j]}");
       }
   }
}