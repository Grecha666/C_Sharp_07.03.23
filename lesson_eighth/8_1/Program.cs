// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае если это невозможно программа должна вывести об этом сообщение

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

void СhangeIJ(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    
    if(rows == colums)
    {
        for (int i = 0; i < rows; ++i)
        {
            for (int j = i; j < colums; ++j)
            {
                (array[i,j],array[j,i]) = (array[j,i],array[i,j]);
            }
        }   
    }
    else
    {
        Console.WriteLine("В этой матрице невозможно поменять местами столбцы со строками");
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
Console.WriteLine();
СhangeIJ(array);
PrintArray(array);
