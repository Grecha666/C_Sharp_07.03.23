// Задайте двумерный массив размера m*n, каждый элемент в массиве находится по формуле А = m + n. Выведите полученный результат на экран

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

int[,] MassNums(int rows, int colums) //выводящий метод
{
    int[,] arr = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i,j] = i + j;
        }
    }
    return arr;
}
    
Console.WriteLine("Напиши количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(m, n);
PrintArray(array);