// Программа, которая выводит случайное трехзначное число
// и удаляет вторую цифру числа.

int num = new Random().Next(100, 1000);
int result = (num / 100) * 10 + num % 10;
System.Console.WriteLine($"{num} -> {result}");