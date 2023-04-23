// Задайте двумерный массив размером m*n, заполненный случайными целыми числами

void PrintArray(int[,]arr) //заполняющий метод
{
    int rows_size = arr.GetLength(0);
    int colums_size = arr.GetLength(1);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MassNums(int rows, int colums, int from, int to) //выводящий метод
{
    int[,] arr = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}
    
Console.WriteLine("Напиши количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(m, n, start, stop);
PrintArray(array);