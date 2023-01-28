// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99]. 

int[] array = GetRandomArray(123);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"count -> {FindNumInInterval(array)}");

int FindNumInInterval(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 250);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}