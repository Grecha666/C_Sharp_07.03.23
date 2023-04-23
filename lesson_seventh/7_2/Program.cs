// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные и замените эти элементы на их квадраты

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

int[,] SquareOfOddNumbers(int [,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i,j]*=arr[i,j];
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
Console.WriteLine();
int[,] array2 = SquareOfOddNumbers(array);
PrintArray(array2);
