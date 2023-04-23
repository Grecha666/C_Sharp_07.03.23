// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите его позиции по горизонтали и вертикали, или напишите, что такого элемента нет

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
    
string FindNum(int[,] arr, int x)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == x)
            {
                return $"Искомое число {x}, его координаты [{i + 1},{j + 1}].";
            }
        }

    }
    return $"Искомое число {x} не найдено";
}

Console.WriteLine("Напиши количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = MassNums(m, n, start, stop);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите число для поиска: ");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindNum(array, n));

