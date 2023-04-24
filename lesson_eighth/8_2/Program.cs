// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

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

int[] Count(int[,]arr, int max)
{
    int[] newMass = new int[max + 1];
    foreach (int elem in arr)
    {
        newMass[elem]++;
    }
    return newMass;
}

 void PrintnewMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Количество {i} = {arr[i]} ");
    }
    Console.WriteLine();
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

int[] y = Count(array, stop);
PrintnewMass(y);

