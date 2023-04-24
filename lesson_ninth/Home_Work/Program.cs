/* Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

void SearchNaturalNumbers(int m, int n)
{
    if (m > n) return;

    if (m % 2 == 0)
    {
    Console.Write($"{m}, ");
    }
    SearchNaturalNumbers(m+1,n);
}
SearchNaturalNumbers(m,n);

*/ 
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int Sum(int m, int n)
{
    if (m == n) return n;
    else return m + Sum(m + 1, n);
}
Console.Write($"Сумма натуральных чисел в промежутке от M до N равно {Sum(m,n)}");