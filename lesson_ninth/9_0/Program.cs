// Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии

void PrintNuns(int n)
{
    if (n == 0) return;
    PrintNuns(n - 1);
    Console.Write($"{n} "); 
}

Console.Write("Напиши число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Result: ");
PrintNuns(N);


