// Двумерный массив

string[,] table = new string[2, 5]; // массив из строк
table[1, 2] = "hello";
for(int rows = 0; rows < 2; rows++)
{
   for (int columns = 0; columns < 3; columns++)
   { 
       Console.WriteLine($"-{table[rows, columns]}-"); 
   }
}
Console.WriteLine();