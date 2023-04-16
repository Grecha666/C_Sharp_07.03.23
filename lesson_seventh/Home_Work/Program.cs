// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Количество строк");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов");
int b = int.Parse(Console.ReadLine()!);

double[,] numbers = new double[a, b];
FillArrayRandom(numbers);
PrintArray(numbers);

*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите количество строк");
int string1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[string1, columns];

FillArrayRandom(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / string1;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);