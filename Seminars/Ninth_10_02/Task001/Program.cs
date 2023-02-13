/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

string NumbersRec(int n)
{
    if (n == 1) return $"{1} ";
    else return NumbersRec(n - 1) + n + " ";
}

Console.WriteLine(NumbersRec(5));