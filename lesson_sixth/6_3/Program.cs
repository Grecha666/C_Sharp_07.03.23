// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

void Fibonacci(int n)
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write($"{a} ");
        (a,b)=(b,a+b);
    }
}

Fibonacci(n);

