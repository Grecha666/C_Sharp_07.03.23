// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

Console.WriteLine("Напишите значения для x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите значения для y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double Length (int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)),3);
}

Console.WriteLine(Length(x1, y1, x2, y2));