// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива 

void PrintArray(int[,]arr) 
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
    Console.WriteLine();
}
int[,] MassNums(int rows, int colums, int from, int to) 
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
    
void FirstLastRow(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int colums_size = arr.GetLength(1);

    for (int j = 0; j < colums_size; j++)
    {
        (arr[0,j], arr[rows_size - 1, j]) = (arr[rows_size - 1, j], arr[0,j]);
    }
}

Console.WriteLine("Напиши количество строк: ");
int rows_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int colums_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] array = MassNums(rows_num, colums_num, start, stop);
PrintArray(array);
FirstLastRow(array);
PrintArray(array);
