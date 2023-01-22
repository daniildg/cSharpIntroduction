//Распределить числа в массиве от большего к меньшему
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

void selectionSort(int[] array)
{
  for(int i = 0; i < array.Length - 1; i++)
  {
    int maxPosition = i;
    
    for(int j = i + 1; j < array.Length - 2; j++)           
    {                                                   
      if(array[j] > array[maxPosition]) maxPosition =j; 
    }                                                   
    //
    int temp = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temp; //обмен двух пременнных местами
  }
}
printArray(arr);
selectionSort(arr);
printArray(arr);