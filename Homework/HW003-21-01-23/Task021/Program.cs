//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Random rnd = new Random();
int x1 = rnd.Next(-10, 11);
int y1 = rnd.Next(-10, 11);
int z1 = rnd.Next(-10, 11);
int x2 = rnd.Next(-10, 11);
int y2 = rnd.Next(-10, 11);
int z2 = rnd.Next(-10, 11);
Console.Write(
  $"A ({x1},{y1},{z1}), B ({x2},{y2},{z2}) -> ");

double result = Math.Sqrt(
  Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1),2));
Console.WriteLine(result);