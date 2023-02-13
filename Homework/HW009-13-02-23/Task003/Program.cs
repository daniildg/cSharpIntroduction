/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 * Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

double Ackerman(double m, double n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine(Ackerman(3, 2)); // 29