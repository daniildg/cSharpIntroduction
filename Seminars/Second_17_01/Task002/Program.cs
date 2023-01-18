// Программа, которая выводит случайное трехзначное число
// и удаляет вторую цифру числа.

int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Number -> {num}");
int result = (num / 100) * 10 + num % 10;
System.Console.WriteLine($"Result -> {result}");