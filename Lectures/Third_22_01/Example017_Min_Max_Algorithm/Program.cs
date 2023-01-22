// Распределить числа в массиве от меньшего к большему
// по приниципу сортировки методом выбора

int[] arr = {1,5,4,3,2,6,7,1,1};

void printArray(int[]array)
{
  int count = array.Length;
  
  for(int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
//printArray(arr); - напечатали заданный алгоритм
void selectionSort(int[] array)
{
  for(int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;
    
    for(int j = i + 1; j < array.Length; j++)           //
    {                                                   //
      if(array[j] < array[minPosition]) minPosition =j; //
    }                                                   // поиск максимального элемента
    //
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary; //обмен двух пременнных местами
  }
}
printArray(arr);    //вывод оригинала массива
selectionSort(arr); //сортировка от меньшего к большему
printArray(arr);    //вывод отсортированного массива