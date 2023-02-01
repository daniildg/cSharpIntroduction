// Рекурсия для числа Фибоначчи

double Fibonacci(int n)
{
   if (n==0) return 0;
   if (n == 1 || n == 2) return 1;
   else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i < 50; i++)
{
   Console.WriteLine($"f{i} = {Fibonacci(i)}");
}