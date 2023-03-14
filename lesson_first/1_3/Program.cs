// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает ВСЕ целые числа от -N до N

Console.WriteLine("Напишите целочисленное число: ");
int number = int.Parse(Console.ReadLine()!);

int count = -number;

while (count != number)
{
    Console.WriteLine(count);
    if (number < 0)
    {
    count--;
    }
    else
    {
    count++;
    }
}