// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
float num1 = new Random().Next(-25, 25); Console.Write($"b1 = {num1} ");
float num2 = new Random().Next(-25, 25); Console.Write($"k1 = {num2} ");
float num3 = new Random().Next(-25, 25); Console.Write($"b2 = {num3} ");
float num4 = new Random().Next(-25, 25); Console.Write($"k2 = {num4}; -> (");
PrintCrossPoint();

float FirstPoint(float b1, float k1, float b2, float k2)
{
  float x = (b2 - b1) / (k1 - k2);
  float y = (k1 * x) + b1;
  return y;
}

float SecondPoint(float b1, float k1, float b2, float k2)
{
  float x = (b2 - b1) / (k1 - k2);
  float y = (k2 * x) + b2;
  return y;
}

void PrintCrossPoint()
{
  Console.Write(FirstPoint(num1, num2, num3, num4) + ", ");
  Console.Write(SecondPoint(num1, num2, num3, num4) + ")");
}