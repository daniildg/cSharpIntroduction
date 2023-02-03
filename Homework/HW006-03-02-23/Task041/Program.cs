// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите ваши числа через пробел -> ");
string line = Console.ReadLine();
string[] sep = line.Split(' ');
int[] convert = Array.ConvertAll<string, int>(sep, int.Parse);
Console.WriteLine($"Чисел больше нуля -> {MoreThanZero(convert)}");

int MoreThanZero(int[] array)
{
  int res = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) res++;
  }
  return res;
}