// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона меньше суммы двух других сторон

Console.Write("a = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("b = ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("c = ");
int c = int.Parse(Console.ReadLine()!);

bool MyFunction(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
    return true;
    else
    return false;
}

Console.WriteLine(MyFunction(a, b, c));
