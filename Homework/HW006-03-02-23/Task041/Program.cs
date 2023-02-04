// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите ваши числа через пробел -> ");
string line = Console.ReadLine();
string[] separate = line.Split(' ');
int[] convert = Array.ConvertAll<string, int>(separate, int.Parse);
Console.WriteLine($"Чисел больше нуля -> {MoreThanZero(convert)}");

static int MoreThanZero(int[] array)
{
  int res = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) res++;
  }
  return res;
}