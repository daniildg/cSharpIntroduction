/*Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int fstNum = 0;
int scdNum = 1;
int n = new Random().Next(3, 15);
Console.Write($"{n} -> {fstNum} {scdNum} ");
for(int i = 3; i <= n; i++)
{
  int fibNum = fstNum + scdNum; 
  Console.Write(fibNum + " ");
  fstNum = scdNum;
  scdNum = fibNum;
}