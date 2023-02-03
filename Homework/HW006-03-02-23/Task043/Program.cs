// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
float b1 = new Random().Next(-25, 25); Console.Write($"b1 = {b1} ");
float k1 = new Random().Next(-25, 25); Console.Write($"k1 = {k1} ");
float b2 = new Random().Next(-25, 25); Console.Write($"b2 = {b2} ");
float k2 = new Random().Next(-25, 25); Console.Write($"k2 = {k2}; ");
float x = (b2 - b1) / (k1 - k2);
Console.WriteLine($"y = ({(k1 * x) + b1}; {(k2 * x) + b2})");