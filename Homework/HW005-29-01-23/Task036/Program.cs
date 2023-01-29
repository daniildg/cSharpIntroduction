//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int[] array = GetRandomArray(10);
PrintArray(array);
Console.WriteLine(UnevenNumSum(array));

int UnevenNumSum(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1) 
        {
            result += array[i];
        }
    }
    return result;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-50, 51);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}