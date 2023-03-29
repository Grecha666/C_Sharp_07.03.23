// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void SumOfSquares(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine(Math.Pow(index,2));
        index++;
    }
}    

Console.WriteLine("Напишите своё число: ");
int num = int.Parse(Console.ReadLine()!);
SumOfSquares(num);

