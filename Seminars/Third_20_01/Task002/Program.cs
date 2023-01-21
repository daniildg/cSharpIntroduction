//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
Random rnd = new Random();
int x1 = rnd.Next(-10, 11);
int y1 = rnd.Next(-10, 11);
int x2 = rnd.Next(-10, 11);
int y2 = rnd.Next(-10, 11);
System.Console.WriteLine($"x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
System.Console.WriteLine(result);